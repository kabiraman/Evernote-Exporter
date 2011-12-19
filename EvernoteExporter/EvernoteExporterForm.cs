using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvernoteExporter
{
    public partial class EvernoteExporterForm : Form
    {
        private const string TITLE = "Evernote Exporter";

        private const string SEPARATOR = " - ";

        private const string TAGLINE = "Schedule your Evernote exports!";

        private const string EXPORTING = "Exporting...";

        private const string EVERNOTE_EXECUTABLE = "ENScript.exe";

        public EvernoteExporterForm()
        {
            InitializeComponent();
        }

        private void EvernoteExporterForm_Load(object sender, EventArgs e)
        {
            PopulateRepeatType();
            Initialize();

            // run every minute
            m_exportTimer.Interval = 60000;
            m_exportTimer.Enabled = true;
            m_exportTimer.Start();

            this.Text = TITLE + SEPARATOR  + TAGLINE;
            m_versionTextBox.Text = "0.4.0";
        }

        private void EvernoteExporterForm_Activated(object sender, System.EventArgs e)
        {
            this.ShowInTaskbar = true;
        }
        
        private void EvernoteExporterForm_Deactivate(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
            else
            {
                if (this.ShowInTaskbar == false) this.ShowInTaskbar = true;
            }
        }

        private void Initialize()
        {
            ReadSettings();
            m_exportNowButton.Enabled = IsExportLocationValid(m_exportLocationTextBox.Text);
            m_saveButton.Enabled = IsExportLocationValid(m_exportLocationTextBox.Text) && 
                IsRepeatScheduleValid(m_repeatsEveryTextBox.Text);

            if (!IsExportStartDateValid()) m_nextExportValue.Text = "None.  Save, to schedule export.";
            OnExportTimerTick();
        }

        private void PopulateRepeatType()
        {
            foreach (string name in Enum.GetNames(typeof(RepeatType)))
            {
                m_repeatsComboBox.Items.Add(name);
            }

            m_repeatsComboBox.SelectedIndex = 0;
        }

        private void ReadSettings()
        {
            m_exportLocationTextBox.Text = Properties.Settings.Default.ExportLocation;
            m_repeatsComboBox.SelectedItem = Properties.Settings.Default.RepeatType;
            m_repeatsEveryTextBox.Text = Properties.Settings.Default.RepeatSchedule.ToString();

            string startDate = FormatDateTime(Properties.Settings.Default.ExportStartDate);
            if (string.IsNullOrEmpty(startDate))
            {
                m_startDateValue.Value = m_startDateValue.MinDate = DateTime.Now;
            }
            else
            {
                m_startDateValue.Value = DateTime.Parse(startDate);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Confirm Save (this will overwrite your existing export schedule)?",
                TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == 
                System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.ExportLocation = m_exportLocationTextBox.Text;
                Properties.Settings.Default.RepeatType = m_repeatsComboBox.SelectedItem.ToString();
                Properties.Settings.Default.RepeatSchedule = m_repeatsEveryTextBox.Text;
                Properties.Settings.Default.ExportStartDate = m_startDateValue.Value.ToString();
                Properties.Settings.Default.ExportEndDate = "";

                Properties.Settings.Default.LastScheduledRun = null;
                
                Properties.Settings.Default.Save();

                OnExportTimerTick();
            }
        }

        private void RevertButton_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void ExportNowButton_Click(object sender, EventArgs e)
        {
            InitializeExport(EVERNOTE_EXECUTABLE, m_exportLocationTextBox.Text);
        }

        private void OpenDialogButton_Click(object sender, EventArgs e)
        {
            if (IsExportLocationValid(m_exportLocationTextBox.Text))
            {
                m_saveFileDialog.FileName = m_exportLocationTextBox.Text;
            }

            if (m_saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_exportLocationTextBox.Text = m_saveFileDialog.FileName;
            }
        }

        private void RepeatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string calculatedEveryLabel = "hours";

            if (m_repeatsComboBox.SelectedItem.ToString() == Enum.GetName(typeof(RepeatType), RepeatType.Daily))
            {
                calculatedEveryLabel = "days";
            }
            else if (m_repeatsComboBox.SelectedItem.ToString() == Enum.GetName(typeof(RepeatType), RepeatType.Weekly))
            {
                calculatedEveryLabel = "weeks";
            }
            else if (m_repeatsComboBox.SelectedItem.ToString() == Enum.GetName(typeof(RepeatType), RepeatType.Monthly))
            {
                calculatedEveryLabel = "months";
            }

            m_calculatedEveryLabel.Text = calculatedEveryLabel;
        }

        private void ExportLocationTextBox_TextChanged(object sender, System.EventArgs e)
        {
            m_exportNowButton.Enabled = IsExportLocationValid(m_exportLocationTextBox.Text);
            m_saveButton.Enabled = IsExportLocationValid(m_exportLocationTextBox.Text) && 
                IsRepeatScheduleValid(m_repeatsEveryTextBox.Text);
        }

        private void RepeatsEveryTextBox_TextChanged(object sender, System.EventArgs e)
        {
            m_saveButton.Enabled = IsExportLocationValid(m_exportLocationTextBox.Text) && 
                IsRepeatScheduleValid(m_repeatsEveryTextBox.Text);
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void ExporterWebsiteValueLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_exporterWebsiteLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(m_exporterWebsiteLinkLabel.Text);
        }

        private void PersonalWebsiteValueLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_personalWebsiteLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(m_personalWebsiteLinkLabel.Text);
        }

        private void ExportTimer_Tick(object sender, EventArgs e)
        {
            OnExportTimerTick();
        }

        private void OnExportTimerTick()
        {
            if (IsExportLocationValid(Properties.Settings.Default.ExportLocation) &&
                IsRepeatScheduleValid(Properties.Settings.Default.RepeatSchedule) &&
                IsRepeatTypeValid(Properties.Settings.Default.RepeatType) && 
                IsExportStartDateValid())
            {
                TryScheduledExport();                
            }
            else
            {
                // TODO[kabiraman]: do something here?
            }
        }

        private void InitializeExport(string pathToEvernote, string exportLocation)
        {
            if (IsExportLocationValid(exportLocation))
            {
                this.Text = TITLE + SEPARATOR + EXPORTING;
                Application.UseWaitCursor = true;
                m_saveButton.Enabled = m_revertButton.Enabled = m_exportNowButton.Enabled = false;
                m_exporter.RunWorkerAsync(new string[] { pathToEvernote, exportLocation });
            }
        }

        private void DoExport(string pathToEvernote, string exportLocation)
        {
            try
            {
                TryDoExport(pathToEvernote, exportLocation);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                    "Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\ENScript.exe");
                if (key == null)
                {
                    throw ex;
                }
                else
                {
                    TryDoExport(key.GetValue("Path").ToString() + pathToEvernote, exportLocation);
                }
            }
        }

        private void TryDoExport(string pathToEvernote, string exportLocation)
        {
            // for quick exports, let the user notice that the export is taking place
            System.Threading.Thread.Sleep(2000);

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = pathToEvernote;
            startInfo.Arguments = string.Format("exportNotes /q any: /f \"{0}\"", exportLocation);
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            System.Diagnostics.Process process = System.Diagnostics.Process.Start(startInfo);
        }

        private void Exporter_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] arguments = e.Argument as string[];
            DoExport(arguments[0], arguments[1]);
        }

        private void Exporter_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            m_lastRunValue.Text = string.Format("{0}, successful", FormatDateTime(DateTime.Now.ToString()));

            if (e.Error != null)
            {
                m_lastRunValue.Text = m_lastRunValue.Text.Replace("successful", "failed");

                System.Diagnostics.Debug.WriteLine(e.Error.ToString());
                MessageBox.Show("Unexpected Export failure!", TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }

            this.Text = TITLE + SEPARATOR + TAGLINE;
            Application.UseWaitCursor = false;
            m_saveButton.Enabled = m_revertButton.Enabled = m_exportNowButton.Enabled = true;            
        }

        private void TryScheduledExport()
        {
            DateTime nextExport = DetermineNextScheduledExport();
            if (nextExport.CompareTo(DateTime.Now) < 0)
            {
                DoScheduledExport();                
            }
            m_nextExportValue.Text = FormatDateTime(DetermineNextScheduledExport().ToString());
        }

        private void DoScheduledExport()
        {
            m_notifyIcon.ShowBalloonTip(2000, TITLE, EXPORTING, ToolTipIcon.Info);
            InitializeExport(EVERNOTE_EXECUTABLE, Properties.Settings.Default.ExportLocation);
            
            Properties.Settings.Default.LastScheduledRun = DateTime.Now.ToString();
            Properties.Settings.Default.Save();
        }

        private DateTime DetermineNextScheduledExport()
        {
            if (Properties.Settings.Default.LastScheduledRun == null)
                return DateTime.Parse(Properties.Settings.Default.ExportStartDate);

            int interval = int.Parse(Properties.Settings.Default.RepeatSchedule);
            DateTime nextExport = DateTime.Parse(Properties.Settings.Default.ExportStartDate);

            while (nextExport.CompareTo(DateTime.Parse(Properties.Settings.Default.LastScheduledRun)) < 0)
            {
                if (Properties.Settings.Default.RepeatType == Enum.GetName(typeof(RepeatType), RepeatType.Hourly))
                {
                    nextExport = nextExport.AddHours(interval);
                }
                else if (Properties.Settings.Default.RepeatType == Enum.GetName(typeof(RepeatType), RepeatType.Daily))
                {
                    nextExport = nextExport.AddDays(interval);
                }
                else if (Properties.Settings.Default.RepeatType == Enum.GetName(typeof(RepeatType), RepeatType.Weekly))
                {
                    nextExport = nextExport.AddDays(interval * 7);
                }
                else
                {
                    nextExport = nextExport.AddMonths(interval);
                }
            }
            
            return nextExport;
        }

        private bool IsExportLocationValid(string exportLocation)
        {
            try
            {
                if (System.IO.Path.GetFileNameWithoutExtension(exportLocation) == string.Empty)
                {
                    return false;
                }
                else if (System.IO.Path.GetExtension(exportLocation) != ".enex")
                {
                    return false;
                }
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                string path = System.IO.Path.GetDirectoryName(exportLocation);
                return System.IO.Directory.Exists(path);
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (System.IO.PathTooLongException)
            {
                return false;
            }
        }


        private bool IsRepeatTypeValid(string repeatType)
        {
            foreach (string name in Enum.GetNames(typeof(RepeatType)))
            {
                if (name == repeatType) return true;
            }

            return false;
        }

        private bool IsRepeatScheduleValid(string repeatSchedule)
        {
            try
            {
                int.Parse(repeatSchedule);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsExportStartDateValid()
        {
            return !string.IsNullOrEmpty(FormatDateTime(Properties.Settings.Default.ExportStartDate));
        }

        private string FormatDateTime(string dateTime)
        {
            if (string.IsNullOrEmpty(dateTime)) return string.Empty;

            try
            {
                return DateTime.Parse(dateTime).ToString("dd MMM, yyyy HH:mm");
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}

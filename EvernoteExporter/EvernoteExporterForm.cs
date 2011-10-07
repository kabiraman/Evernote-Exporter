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

        private string m_lastExported;
        
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
            m_versionTextBox.Text = "0.2.0";
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
            m_saveButton.Enabled = IsExportLocationValid(m_exportLocationTextBox.Text) && 
                IsRepeatScheduleValid(m_repeatsEveryTextBox.Text);            
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
            m_startDateValue.Text = Utility.FormatDateTime(Properties.Settings.Default.ExportStartDate);
            m_repeatsComboBox.SelectedItem = Properties.Settings.Default.RepeatType;
            m_repeatsEveryTextBox.Text = Properties.Settings.Default.RepeatSchedule.ToString();
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
                Properties.Settings.Default.ExportStartDate = DateTime.Now.ToString();
                Properties.Settings.Default.ExportEndDate = "";
                Properties.Settings.Default.Save();

                m_startDateValue.Text = Utility.FormatDateTime(Properties.Settings.Default.ExportStartDate);

                m_lastExported = null;
                OnExportTimerTick();
            }
        }

        private void RevertButton_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void ExportNowButton_Click(object sender, EventArgs e)
        {
            InitializeExport(EVERNOTE_EXECUTABLE);
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

        private void ExportTimer_Tick(object sender, EventArgs e)
        {
            OnExportTimerTick();
        }

        private void OnExportTimerTick()
        {
            if (IsExportLocationValid(Properties.Settings.Default.ExportLocation) &&
                IsRepeatScheduleValid(Properties.Settings.Default.RepeatSchedule) &&
                IsRepeatTypeValid(Properties.Settings.Default.RepeatType))
            {
                if (m_lastExported == null)
                {
                    InitializeExport(EVERNOTE_EXECUTABLE);
                    m_lastExported = DateTime.Now.ToString();
                }
                else
                {
                    TryScheduledExport();
                }

                m_nextExportValue.Text = Utility.FormatDateTime(DetermineNextScheduledExport().ToString());
            }
            else
            {
                // TODO[kabiraman]: do something here?
            }
        }

        private void InitializeExport(string pathToEvernote)
        {
            if (IsExportLocationValid(Properties.Settings.Default.ExportLocation))
            {
                this.Text = TITLE + SEPARATOR + EXPORTING;
                Application.UseWaitCursor = true;
                m_saveButton.Enabled = m_revertButton.Enabled = m_exportNowButton.Enabled = false;
                m_exporter.RunWorkerAsync(pathToEvernote);
            }
        }

        private void DoExport(string pathToEvernote)
        {
            try
            {
                TryDoExport(pathToEvernote);
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
                    TryDoExport(key.GetValue("Path").ToString() + pathToEvernote);
                }
            }
        }

        private void TryDoExport(string pathToEvernote)
        {
            // for quick exports, let the user notice that the export is taking place
            System.Threading.Thread.Sleep(2000);

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = pathToEvernote;
            startInfo.Arguments = string.Format("exportNotes /q any: /f \"{0}\"",
                Properties.Settings.Default.ExportLocation);
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            System.Diagnostics.Process process = System.Diagnostics.Process.Start(startInfo);
        }

        private void Exporter_DoWork(object sender, DoWorkEventArgs e)
        {
            DoExport(e.Argument.ToString());
        }

        private void Exporter_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            m_lastRunValue.Text = string.Format("{0}, successful", Utility.FormatDateTime(DateTime.Now.ToString()));

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
        }

        private void DoScheduledExport()
        {
            m_notifyIcon.ShowBalloonTip(2000, TITLE, EXPORTING, ToolTipIcon.Info);
            InitializeExport(EVERNOTE_EXECUTABLE);
            m_lastExported = DateTime.Now.ToString();
        }

        private DateTime DetermineNextScheduledExport()
        {
            DateTime lastExported = DateTime.Parse(m_lastExported);
            int interval = int.Parse(Properties.Settings.Default.RepeatSchedule);

            if (Properties.Settings.Default.RepeatType == Enum.GetName(typeof(RepeatType), RepeatType.Hourly))
            {
                return lastExported.AddHours(interval);
            }
            else if (Properties.Settings.Default.RepeatType == Enum.GetName(typeof(RepeatType), RepeatType.Daily))
            {
                return lastExported.AddDays(interval);
            }
            else if (Properties.Settings.Default.RepeatType == Enum.GetName(typeof(RepeatType), RepeatType.Weekly))
            {
                return lastExported.AddDays(interval * 7);
            }
            else
            {
                return lastExported.AddMonths(interval);
            }
        }
    }
}

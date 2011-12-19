namespace EvernoteExporter
{
    partial class EvernoteExporterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvernoteExporterForm));
            this.m_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.m_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.m_exportTimer = new System.Windows.Forms.Timer(this.components);
            this.m_exporter = new System.ComponentModel.BackgroundWorker();
            this.m_tabControl = new System.Windows.Forms.TabControl();
            this.m_exporterTab = new System.Windows.Forms.TabPage();
            this.m_exportNowButton = new System.Windows.Forms.Button();
            this.m_revertButton = new System.Windows.Forms.Button();
            this.m_saveButton = new System.Windows.Forms.Button();
            this.m_repeatSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.m_repeatsEveryTextBox = new System.Windows.Forms.TextBox();
            this.m_calculatedEveryLabel = new System.Windows.Forms.Label();
            this.m_repeatsEveryLabel = new System.Windows.Forms.Label();
            this.m_repeatsComboBox = new System.Windows.Forms.ComboBox();
            this.m_repeatsLabel = new System.Windows.Forms.Label();
            this.m_basicSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.m_startDateLabel = new System.Windows.Forms.Label();
            this.m_openDialogButton = new System.Windows.Forms.Button();
            this.m_exportLocationTextBox = new System.Windows.Forms.TextBox();
            this.m_exportLocationLabel = new System.Windows.Forms.Label();
            this.m_aboutTab = new System.Windows.Forms.TabPage();
            this.m_statusGroupBox = new System.Windows.Forms.GroupBox();
            this.m_nextExportValue = new System.Windows.Forms.Label();
            this.m_nextExportLabel = new System.Windows.Forms.Label();
            this.m_lastRunValue = new System.Windows.Forms.Label();
            this.m_lastRunLabel = new System.Windows.Forms.Label();
            this.m_acknowledgementValue = new System.Windows.Forms.TextBox();
            this.m_acknowledgementLabel = new System.Windows.Forms.Label();
            this.m_personalWebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.m_personalWebsiteLabel = new System.Windows.Forms.Label();
            this.m_exporterWebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.m_lblLicense = new System.Windows.Forms.Label();
            this.m_exporterWebsiteLabel = new System.Windows.Forms.Label();
            this.m_developerTextBox = new System.Windows.Forms.TextBox();
            this.m_developerLabel = new System.Windows.Forms.Label();
            this.m_versionTextBox = new System.Windows.Forms.TextBox();
            this.m_versionLabel = new System.Windows.Forms.Label();
            this.m_startDateValue = new System.Windows.Forms.DateTimePicker();
            this.m_tabControl.SuspendLayout();
            this.m_exporterTab.SuspendLayout();
            this.m_repeatSettingsGroupBox.SuspendLayout();
            this.m_basicSettingsGroupBox.SuspendLayout();
            this.m_aboutTab.SuspendLayout();
            this.m_statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_saveFileDialog
            // 
            this.m_saveFileDialog.DefaultExt = "enex";
            this.m_saveFileDialog.Filter = "Evernote export files|*.enex";
            // 
            // m_notifyIcon
            // 
            this.m_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("m_notifyIcon.Icon")));
            this.m_notifyIcon.Text = "Evernote Exporter";
            this.m_notifyIcon.Visible = true;
            this.m_notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // m_exportTimer
            // 
            this.m_exportTimer.Interval = 1000;
            this.m_exportTimer.Tick += new System.EventHandler(this.ExportTimer_Tick);
            // 
            // m_exporter
            // 
            this.m_exporter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Exporter_DoWork);
            this.m_exporter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Exporter_RunWorkerCompleted);
            // 
            // m_tabControl
            // 
            this.m_tabControl.Controls.Add(this.m_exporterTab);
            this.m_tabControl.Controls.Add(this.m_aboutTab);
            this.m_tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tabControl.Location = new System.Drawing.Point(12, 12);
            this.m_tabControl.Name = "m_tabControl";
            this.m_tabControl.SelectedIndex = 0;
            this.m_tabControl.Size = new System.Drawing.Size(446, 307);
            this.m_tabControl.TabIndex = 9;
            // 
            // m_exporterTab
            // 
            this.m_exporterTab.Controls.Add(this.m_exportNowButton);
            this.m_exporterTab.Controls.Add(this.m_revertButton);
            this.m_exporterTab.Controls.Add(this.m_saveButton);
            this.m_exporterTab.Controls.Add(this.m_repeatSettingsGroupBox);
            this.m_exporterTab.Controls.Add(this.m_basicSettingsGroupBox);
            this.m_exporterTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_exporterTab.Location = new System.Drawing.Point(4, 25);
            this.m_exporterTab.Name = "m_exporterTab";
            this.m_exporterTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_exporterTab.Size = new System.Drawing.Size(438, 278);
            this.m_exporterTab.TabIndex = 0;
            this.m_exporterTab.Text = "Export";
            this.m_exporterTab.UseVisualStyleBackColor = true;
            // 
            // m_exportNowButton
            // 
            this.m_exportNowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_exportNowButton.Location = new System.Drawing.Point(296, 236);
            this.m_exportNowButton.Name = "m_exportNowButton";
            this.m_exportNowButton.Size = new System.Drawing.Size(98, 23);
            this.m_exportNowButton.TabIndex = 13;
            this.m_exportNowButton.Text = "Export Now";
            this.m_exportNowButton.UseVisualStyleBackColor = true;
            this.m_exportNowButton.Click += new System.EventHandler(this.ExportNowButton_Click);
            // 
            // m_revertButton
            // 
            this.m_revertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_revertButton.Location = new System.Drawing.Point(206, 236);
            this.m_revertButton.Name = "m_revertButton";
            this.m_revertButton.Size = new System.Drawing.Size(75, 23);
            this.m_revertButton.TabIndex = 12;
            this.m_revertButton.Text = "Revert";
            this.m_revertButton.UseVisualStyleBackColor = true;
            this.m_revertButton.Click += new System.EventHandler(this.RevertButton_Click);
            // 
            // m_saveButton
            // 
            this.m_saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_saveButton.Location = new System.Drawing.Point(125, 236);
            this.m_saveButton.Name = "m_saveButton";
            this.m_saveButton.Size = new System.Drawing.Size(75, 23);
            this.m_saveButton.TabIndex = 11;
            this.m_saveButton.Text = "Save";
            this.m_saveButton.UseVisualStyleBackColor = true;
            this.m_saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // m_repeatSettingsGroupBox
            // 
            this.m_repeatSettingsGroupBox.Controls.Add(this.m_repeatsEveryTextBox);
            this.m_repeatSettingsGroupBox.Controls.Add(this.m_calculatedEveryLabel);
            this.m_repeatSettingsGroupBox.Controls.Add(this.m_repeatsEveryLabel);
            this.m_repeatSettingsGroupBox.Controls.Add(this.m_repeatsComboBox);
            this.m_repeatSettingsGroupBox.Controls.Add(this.m_repeatsLabel);
            this.m_repeatSettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_repeatSettingsGroupBox.Location = new System.Drawing.Point(6, 125);
            this.m_repeatSettingsGroupBox.Name = "m_repeatSettingsGroupBox";
            this.m_repeatSettingsGroupBox.Size = new System.Drawing.Size(388, 100);
            this.m_repeatSettingsGroupBox.TabIndex = 10;
            this.m_repeatSettingsGroupBox.TabStop = false;
            this.m_repeatSettingsGroupBox.Text = "Repeat";
            // 
            // m_repeatsEveryTextBox
            // 
            this.m_repeatsEveryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_repeatsEveryTextBox.Location = new System.Drawing.Point(119, 66);
            this.m_repeatsEveryTextBox.MaxLength = 3;
            this.m_repeatsEveryTextBox.Name = "m_repeatsEveryTextBox";
            this.m_repeatsEveryTextBox.Size = new System.Drawing.Size(57, 20);
            this.m_repeatsEveryTextBox.TabIndex = 6;
            this.m_repeatsEveryTextBox.Text = "1";
            this.m_repeatsEveryTextBox.TextChanged += new System.EventHandler(this.RepeatsEveryTextBox_TextChanged);
            // 
            // m_calculatedEveryLabel
            // 
            this.m_calculatedEveryLabel.AutoSize = true;
            this.m_calculatedEveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_calculatedEveryLabel.Location = new System.Drawing.Point(182, 69);
            this.m_calculatedEveryLabel.Name = "m_calculatedEveryLabel";
            this.m_calculatedEveryLabel.Size = new System.Drawing.Size(33, 13);
            this.m_calculatedEveryLabel.TabIndex = 5;
            this.m_calculatedEveryLabel.Text = "hours";
            // 
            // m_repeatsEveryLabel
            // 
            this.m_repeatsEveryLabel.AutoSize = true;
            this.m_repeatsEveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_repeatsEveryLabel.Location = new System.Drawing.Point(25, 66);
            this.m_repeatsEveryLabel.Name = "m_repeatsEveryLabel";
            this.m_repeatsEveryLabel.Size = new System.Drawing.Size(88, 13);
            this.m_repeatsEveryLabel.TabIndex = 3;
            this.m_repeatsEveryLabel.Text = "Repeat Every:";
            // 
            // m_repeatsComboBox
            // 
            this.m_repeatsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_repeatsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_repeatsComboBox.FormattingEnabled = true;
            this.m_repeatsComboBox.Location = new System.Drawing.Point(119, 31);
            this.m_repeatsComboBox.Name = "m_repeatsComboBox";
            this.m_repeatsComboBox.Size = new System.Drawing.Size(121, 21);
            this.m_repeatsComboBox.TabIndex = 2;
            this.m_repeatsComboBox.SelectedIndexChanged += new System.EventHandler(this.RepeatsComboBox_SelectedIndexChanged);
            // 
            // m_repeatsLabel
            // 
            this.m_repeatsLabel.AutoSize = true;
            this.m_repeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_repeatsLabel.Location = new System.Drawing.Point(55, 36);
            this.m_repeatsLabel.Name = "m_repeatsLabel";
            this.m_repeatsLabel.Size = new System.Drawing.Size(58, 13);
            this.m_repeatsLabel.TabIndex = 1;
            this.m_repeatsLabel.Text = "Repeats:";
            // 
            // m_basicSettingsGroupBox
            // 
            this.m_basicSettingsGroupBox.Controls.Add(this.m_startDateValue);
            this.m_basicSettingsGroupBox.Controls.Add(this.m_startDateLabel);
            this.m_basicSettingsGroupBox.Controls.Add(this.m_openDialogButton);
            this.m_basicSettingsGroupBox.Controls.Add(this.m_exportLocationTextBox);
            this.m_basicSettingsGroupBox.Controls.Add(this.m_exportLocationLabel);
            this.m_basicSettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_basicSettingsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.m_basicSettingsGroupBox.Name = "m_basicSettingsGroupBox";
            this.m_basicSettingsGroupBox.Size = new System.Drawing.Size(388, 100);
            this.m_basicSettingsGroupBox.TabIndex = 9;
            this.m_basicSettingsGroupBox.TabStop = false;
            this.m_basicSettingsGroupBox.Text = "Basic";
            // 
            // m_startDateLabel
            // 
            this.m_startDateLabel.AutoSize = true;
            this.m_startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_startDateLabel.Location = new System.Drawing.Point(37, 59);
            this.m_startDateLabel.Name = "m_startDateLabel";
            this.m_startDateLabel.Size = new System.Drawing.Size(69, 13);
            this.m_startDateLabel.TabIndex = 5;
            this.m_startDateLabel.Text = "Start Date:";
            // 
            // m_openDialogButton
            // 
            this.m_openDialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_openDialogButton.Location = new System.Drawing.Point(342, 28);
            this.m_openDialogButton.Name = "m_openDialogButton";
            this.m_openDialogButton.Size = new System.Drawing.Size(37, 23);
            this.m_openDialogButton.TabIndex = 4;
            this.m_openDialogButton.Text = "...";
            this.m_openDialogButton.UseVisualStyleBackColor = true;
            this.m_openDialogButton.Click += new System.EventHandler(this.OpenDialogButton_Click);
            // 
            // m_exportLocationTextBox
            // 
            this.m_exportLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_exportLocationTextBox.Location = new System.Drawing.Point(119, 28);
            this.m_exportLocationTextBox.Name = "m_exportLocationTextBox";
            this.m_exportLocationTextBox.Size = new System.Drawing.Size(217, 20);
            this.m_exportLocationTextBox.TabIndex = 3;
            this.m_exportLocationTextBox.TextChanged += new System.EventHandler(this.ExportLocationTextBox_TextChanged);
            // 
            // m_exportLocationLabel
            // 
            this.m_exportLocationLabel.AutoSize = true;
            this.m_exportLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_exportLocationLabel.Location = new System.Drawing.Point(6, 30);
            this.m_exportLocationLabel.Name = "m_exportLocationLabel";
            this.m_exportLocationLabel.Size = new System.Drawing.Size(100, 13);
            this.m_exportLocationLabel.TabIndex = 0;
            this.m_exportLocationLabel.Text = "Export Location:";
            // 
            // m_aboutTab
            // 
            this.m_aboutTab.Controls.Add(this.m_statusGroupBox);
            this.m_aboutTab.Controls.Add(this.m_acknowledgementValue);
            this.m_aboutTab.Controls.Add(this.m_acknowledgementLabel);
            this.m_aboutTab.Controls.Add(this.m_personalWebsiteLinkLabel);
            this.m_aboutTab.Controls.Add(this.m_personalWebsiteLabel);
            this.m_aboutTab.Controls.Add(this.m_exporterWebsiteLinkLabel);
            this.m_aboutTab.Controls.Add(this.m_lblLicense);
            this.m_aboutTab.Controls.Add(this.m_exporterWebsiteLabel);
            this.m_aboutTab.Controls.Add(this.m_developerTextBox);
            this.m_aboutTab.Controls.Add(this.m_developerLabel);
            this.m_aboutTab.Controls.Add(this.m_versionTextBox);
            this.m_aboutTab.Controls.Add(this.m_versionLabel);
            this.m_aboutTab.Location = new System.Drawing.Point(4, 25);
            this.m_aboutTab.Name = "m_aboutTab";
            this.m_aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_aboutTab.Size = new System.Drawing.Size(438, 278);
            this.m_aboutTab.TabIndex = 1;
            this.m_aboutTab.Text = "About";
            this.m_aboutTab.UseVisualStyleBackColor = true;
            // 
            // m_statusGroupBox
            // 
            this.m_statusGroupBox.Controls.Add(this.m_nextExportValue);
            this.m_statusGroupBox.Controls.Add(this.m_nextExportLabel);
            this.m_statusGroupBox.Controls.Add(this.m_lastRunValue);
            this.m_statusGroupBox.Controls.Add(this.m_lastRunLabel);
            this.m_statusGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_statusGroupBox.Location = new System.Drawing.Point(9, 196);
            this.m_statusGroupBox.Name = "m_statusGroupBox";
            this.m_statusGroupBox.Size = new System.Drawing.Size(388, 76);
            this.m_statusGroupBox.TabIndex = 42;
            this.m_statusGroupBox.TabStop = false;
            this.m_statusGroupBox.Text = "Status";
            // 
            // m_nextExportValue
            // 
            this.m_nextExportValue.AutoSize = true;
            this.m_nextExportValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_nextExportValue.Location = new System.Drawing.Point(169, 44);
            this.m_nextExportValue.Name = "m_nextExportValue";
            this.m_nextExportValue.Size = new System.Drawing.Size(0, 13);
            this.m_nextExportValue.TabIndex = 45;
            // 
            // m_nextExportLabel
            // 
            this.m_nextExportLabel.AutoSize = true;
            this.m_nextExportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_nextExportLabel.Location = new System.Drawing.Point(26, 44);
            this.m_nextExportLabel.Name = "m_nextExportLabel";
            this.m_nextExportLabel.Size = new System.Drawing.Size(141, 13);
            this.m_nextExportLabel.TabIndex = 44;
            this.m_nextExportLabel.Text = "Next Scheduled Export:";
            // 
            // m_lastRunValue
            // 
            this.m_lastRunValue.AutoSize = true;
            this.m_lastRunValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lastRunValue.Location = new System.Drawing.Point(169, 18);
            this.m_lastRunValue.Name = "m_lastRunValue";
            this.m_lastRunValue.Size = new System.Drawing.Size(0, 13);
            this.m_lastRunValue.TabIndex = 43;
            // 
            // m_lastRunLabel
            // 
            this.m_lastRunLabel.AutoSize = true;
            this.m_lastRunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lastRunLabel.Location = new System.Drawing.Point(48, 18);
            this.m_lastRunLabel.Name = "m_lastRunLabel";
            this.m_lastRunLabel.Size = new System.Drawing.Size(112, 13);
            this.m_lastRunLabel.TabIndex = 42;
            this.m_lastRunLabel.Text = "Last Export ran at:";
            // 
            // m_acknowledgementValue
            // 
            this.m_acknowledgementValue.AcceptsReturn = true;
            this.m_acknowledgementValue.BackColor = System.Drawing.Color.White;
            this.m_acknowledgementValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_acknowledgementValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_acknowledgementValue.Location = new System.Drawing.Point(181, 159);
            this.m_acknowledgementValue.Multiline = true;
            this.m_acknowledgementValue.Name = "m_acknowledgementValue";
            this.m_acknowledgementValue.ReadOnly = true;
            this.m_acknowledgementValue.Size = new System.Drawing.Size(251, 31);
            this.m_acknowledgementValue.TabIndex = 39;
            this.m_acknowledgementValue.Text = "The Evernote Exporter logo has been licensed from Everaldo Coelho (http://www.eve" +
    "raldo.com)";
            // 
            // m_acknowledgementLabel
            // 
            this.m_acknowledgementLabel.AutoSize = true;
            this.m_acknowledgementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_acknowledgementLabel.Location = new System.Drawing.Point(6, 159);
            this.m_acknowledgementLabel.Name = "m_acknowledgementLabel";
            this.m_acknowledgementLabel.Size = new System.Drawing.Size(107, 13);
            this.m_acknowledgementLabel.TabIndex = 38;
            this.m_acknowledgementLabel.Text = "Acknowledgment:";
            // 
            // m_personalWebsiteLinkLabel
            // 
            this.m_personalWebsiteLinkLabel.AutoSize = true;
            this.m_personalWebsiteLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_personalWebsiteLinkLabel.Location = new System.Drawing.Point(178, 130);
            this.m_personalWebsiteLinkLabel.Name = "m_personalWebsiteLinkLabel";
            this.m_personalWebsiteLinkLabel.Size = new System.Drawing.Size(179, 13);
            this.m_personalWebsiteLinkLabel.TabIndex = 37;
            this.m_personalWebsiteLinkLabel.TabStop = true;
            this.m_personalWebsiteLinkLabel.Text = "http://karthikabiraman.brinkster.net/";
            this.m_personalWebsiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PersonalWebsiteValueLinkLabel_LinkClicked);
            // 
            // m_personalWebsiteLabel
            // 
            this.m_personalWebsiteLabel.AutoSize = true;
            this.m_personalWebsiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_personalWebsiteLabel.Location = new System.Drawing.Point(6, 130);
            this.m_personalWebsiteLabel.Name = "m_personalWebsiteLabel";
            this.m_personalWebsiteLabel.Size = new System.Drawing.Size(110, 13);
            this.m_personalWebsiteLabel.TabIndex = 36;
            this.m_personalWebsiteLabel.Text = "Personal Website:";
            // 
            // m_exporterWebsiteLinkLabel
            // 
            this.m_exporterWebsiteLinkLabel.AutoSize = true;
            this.m_exporterWebsiteLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_exporterWebsiteLinkLabel.Location = new System.Drawing.Point(178, 101);
            this.m_exporterWebsiteLinkLabel.Name = "m_exporterWebsiteLinkLabel";
            this.m_exporterWebsiteLinkLabel.Size = new System.Drawing.Size(187, 13);
            this.m_exporterWebsiteLinkLabel.TabIndex = 35;
            this.m_exporterWebsiteLinkLabel.TabStop = true;
            this.m_exporterWebsiteLinkLabel.Text = "http://evernoteexporter.codeplex.com";
            this.m_exporterWebsiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExporterWebsiteValueLinkLabel_LinkClicked);
            // 
            // m_lblLicense
            // 
            this.m_lblLicense.AutoSize = true;
            this.m_lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblLicense.Location = new System.Drawing.Point(6, 14);
            this.m_lblLicense.Name = "m_lblLicense";
            this.m_lblLicense.Size = new System.Drawing.Size(402, 13);
            this.m_lblLicense.TabIndex = 34;
            this.m_lblLicense.Text = "Evernote Exporter is released under the GNU General Public License.";
            // 
            // m_exporterWebsiteLabel
            // 
            this.m_exporterWebsiteLabel.AutoSize = true;
            this.m_exporterWebsiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_exporterWebsiteLabel.Location = new System.Drawing.Point(6, 101);
            this.m_exporterWebsiteLabel.Name = "m_exporterWebsiteLabel";
            this.m_exporterWebsiteLabel.Size = new System.Drawing.Size(163, 13);
            this.m_exporterWebsiteLabel.TabIndex = 33;
            this.m_exporterWebsiteLabel.Text = "Evernote Exporter Website:";
            // 
            // m_developerTextBox
            // 
            this.m_developerTextBox.AcceptsReturn = true;
            this.m_developerTextBox.BackColor = System.Drawing.Color.White;
            this.m_developerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_developerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_developerTextBox.Location = new System.Drawing.Point(181, 71);
            this.m_developerTextBox.Name = "m_developerTextBox";
            this.m_developerTextBox.ReadOnly = true;
            this.m_developerTextBox.Size = new System.Drawing.Size(219, 13);
            this.m_developerTextBox.TabIndex = 32;
            this.m_developerTextBox.Text = "Karthik Abiraman";
            // 
            // m_developerLabel
            // 
            this.m_developerLabel.AutoSize = true;
            this.m_developerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_developerLabel.Location = new System.Drawing.Point(6, 71);
            this.m_developerLabel.Name = "m_developerLabel";
            this.m_developerLabel.Size = new System.Drawing.Size(89, 13);
            this.m_developerLabel.TabIndex = 31;
            this.m_developerLabel.Text = "Developed by:";
            // 
            // m_versionTextBox
            // 
            this.m_versionTextBox.AcceptsReturn = true;
            this.m_versionTextBox.BackColor = System.Drawing.Color.White;
            this.m_versionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_versionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_versionTextBox.Location = new System.Drawing.Point(181, 42);
            this.m_versionTextBox.Name = "m_versionTextBox";
            this.m_versionTextBox.ReadOnly = true;
            this.m_versionTextBox.Size = new System.Drawing.Size(221, 13);
            this.m_versionTextBox.TabIndex = 30;
            // 
            // m_versionLabel
            // 
            this.m_versionLabel.AutoSize = true;
            this.m_versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_versionLabel.Location = new System.Drawing.Point(6, 42);
            this.m_versionLabel.Name = "m_versionLabel";
            this.m_versionLabel.Size = new System.Drawing.Size(53, 13);
            this.m_versionLabel.TabIndex = 29;
            this.m_versionLabel.Text = "Version:";
            // 
            // m_startDateValue
            // 
            this.m_startDateValue.CustomFormat = "dd MMM, yyyy HH:mm";
            this.m_startDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_startDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_startDateValue.Location = new System.Drawing.Point(119, 59);
            this.m_startDateValue.Name = "m_startDateValue";
            this.m_startDateValue.Size = new System.Drawing.Size(217, 20);
            this.m_startDateValue.TabIndex = 10;
            // 
            // EvernoteExporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 328);
            this.Controls.Add(this.m_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EvernoteExporterForm";
            this.Activated += new System.EventHandler(this.EvernoteExporterForm_Activated);
            this.Deactivate += new System.EventHandler(this.EvernoteExporterForm_Deactivate);
            this.Load += new System.EventHandler(this.EvernoteExporterForm_Load);
            this.m_tabControl.ResumeLayout(false);
            this.m_exporterTab.ResumeLayout(false);
            this.m_repeatSettingsGroupBox.ResumeLayout(false);
            this.m_repeatSettingsGroupBox.PerformLayout();
            this.m_basicSettingsGroupBox.ResumeLayout(false);
            this.m_basicSettingsGroupBox.PerformLayout();
            this.m_aboutTab.ResumeLayout(false);
            this.m_aboutTab.PerformLayout();
            this.m_statusGroupBox.ResumeLayout(false);
            this.m_statusGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog m_saveFileDialog;
        private System.Windows.Forms.NotifyIcon m_notifyIcon;
        private System.Windows.Forms.Timer m_exportTimer;
        private System.ComponentModel.BackgroundWorker m_exporter;
        private System.Windows.Forms.TabControl m_tabControl;
        private System.Windows.Forms.TabPage m_exporterTab;
        private System.Windows.Forms.TabPage m_aboutTab;
        private System.Windows.Forms.TextBox m_acknowledgementValue;
        private System.Windows.Forms.Label m_acknowledgementLabel;
        private System.Windows.Forms.LinkLabel m_personalWebsiteLinkLabel;
        private System.Windows.Forms.Label m_personalWebsiteLabel;
        private System.Windows.Forms.LinkLabel m_exporterWebsiteLinkLabel;
        private System.Windows.Forms.Label m_lblLicense;
        private System.Windows.Forms.Label m_exporterWebsiteLabel;
        private System.Windows.Forms.TextBox m_developerTextBox;
        private System.Windows.Forms.Label m_developerLabel;
        private System.Windows.Forms.TextBox m_versionTextBox;
        private System.Windows.Forms.Label m_versionLabel;
        private System.Windows.Forms.Button m_exportNowButton;
        private System.Windows.Forms.Button m_revertButton;
        private System.Windows.Forms.Button m_saveButton;
        private System.Windows.Forms.GroupBox m_repeatSettingsGroupBox;
        private System.Windows.Forms.TextBox m_repeatsEveryTextBox;
        private System.Windows.Forms.Label m_calculatedEveryLabel;
        private System.Windows.Forms.Label m_repeatsEveryLabel;
        private System.Windows.Forms.ComboBox m_repeatsComboBox;
        private System.Windows.Forms.Label m_repeatsLabel;
        private System.Windows.Forms.GroupBox m_basicSettingsGroupBox;
        private System.Windows.Forms.Button m_openDialogButton;
        private System.Windows.Forms.TextBox m_exportLocationTextBox;
        private System.Windows.Forms.Label m_exportLocationLabel;
        private System.Windows.Forms.Label m_startDateLabel;
        private System.Windows.Forms.GroupBox m_statusGroupBox;
        private System.Windows.Forms.Label m_nextExportValue;
        private System.Windows.Forms.Label m_nextExportLabel;
        private System.Windows.Forms.Label m_lastRunValue;
        private System.Windows.Forms.Label m_lastRunLabel;
        private System.Windows.Forms.DateTimePicker m_startDateValue;
    }
}


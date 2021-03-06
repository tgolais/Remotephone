
namespace Remotephone
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AvailbleDevicesBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshDeviceBtn = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AccessLevelInfoLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SdkLevelInfoLabel = new System.Windows.Forms.Label();
            this.DeviceModelInfoLabel = new System.Windows.Forms.Label();
            this.DeviceBrandInfoLabel = new System.Windows.Forms.Label();
            this.AndroidVersionInfoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StreamBtn = new System.Windows.Forms.Button();
            this.EnableTcpConnectionBtn = new System.Windows.Forms.Button();
            this.ConnectionSettingsGroup = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SettingsGroup = new System.Windows.Forms.GroupBox();
            this.AlwaysOnTopCheck = new System.Windows.Forms.CheckBox();
            this.DisableScreensaverCheck = new System.Windows.Forms.CheckBox();
            this.RenderDelayedFramesCheck = new System.Windows.Forms.CheckBox();
            this.ShowTouchesCheck = new System.Windows.Forms.CheckBox();
            this.KeepScreenOffCheck = new System.Windows.Forms.CheckBox();
            this.PreventSleepingCheck = new System.Windows.Forms.CheckBox();
            this.FpsBox = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.DisableControlsCheck = new System.Windows.Forms.CheckBox();
            this.FullscreenCheck = new System.Windows.Forms.CheckBox();
            this.HideWindowBordersCheck = new System.Windows.Forms.CheckBox();
            this.EnableRecordingCheck = new System.Windows.Forms.CheckBox();
            this.BitrateBox = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.WifiConnectionInfo = new System.Windows.Forms.TextBox();
            this.WifiConnectBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.ActionsGroup = new System.Windows.Forms.GroupBox();
            this.InstallDevDriversBtn = new System.Windows.Forms.Button();
            this.KillAdbServerBtn = new System.Windows.Forms.Button();
            this.RepoUri = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ConnectionSettingsGroup.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FpsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.ActionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AvailbleDevicesBox
            // 
            this.AvailbleDevicesBox.FormattingEnabled = true;
            this.AvailbleDevicesBox.ItemHeight = 15;
            this.AvailbleDevicesBox.Location = new System.Drawing.Point(6, 22);
            this.AvailbleDevicesBox.Name = "AvailbleDevicesBox";
            this.AvailbleDevicesBox.Size = new System.Drawing.Size(195, 454);
            this.AvailbleDevicesBox.TabIndex = 0;
            this.AvailbleDevicesBox.SelectedIndexChanged += new System.EventHandler(this.AvailbleDevicesBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshDeviceBtn);
            this.groupBox1.Controls.Add(this.AvailbleDevicesBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 531);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Availble devices";
            // 
            // RefreshDeviceBtn
            // 
            this.RefreshDeviceBtn.Location = new System.Drawing.Point(6, 482);
            this.RefreshDeviceBtn.Name = "RefreshDeviceBtn";
            this.RefreshDeviceBtn.Size = new System.Drawing.Size(195, 48);
            this.RefreshDeviceBtn.TabIndex = 1;
            this.RefreshDeviceBtn.Text = "Refresh";
            this.RefreshDeviceBtn.UseVisualStyleBackColor = true;
            this.RefreshDeviceBtn.Click += new System.EventHandler(this.RefreshDeviceBtn_Click);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(218, 519);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(778, 23);
            this.Progress.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AccessLevelInfoLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.SdkLevelInfoLabel);
            this.groupBox2.Controls.Add(this.DeviceModelInfoLabel);
            this.groupBox2.Controls.Add(this.DeviceBrandInfoLabel);
            this.groupBox2.Controls.Add(this.AndroidVersionInfoLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(708, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phone informations";
            // 
            // AccessLevelInfoLabel
            // 
            this.AccessLevelInfoLabel.AutoSize = true;
            this.AccessLevelInfoLabel.Location = new System.Drawing.Point(97, 122);
            this.AccessLevelInfoLabel.Name = "AccessLevelInfoLabel";
            this.AccessLevelInfoLabel.Size = new System.Drawing.Size(52, 15);
            this.AccessLevelInfoLabel.TabIndex = 9;
            this.AccessLevelInfoLabel.Text = "Network";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Root or Magisk:";
            // 
            // SdkLevelInfoLabel
            // 
            this.SdkLevelInfoLabel.AutoSize = true;
            this.SdkLevelInfoLabel.Location = new System.Drawing.Point(67, 94);
            this.SdkLevelInfoLabel.Name = "SdkLevelInfoLabel";
            this.SdkLevelInfoLabel.Size = new System.Drawing.Size(19, 15);
            this.SdkLevelInfoLabel.TabIndex = 7;
            this.SdkLevelInfoLabel.Text = "29";
            // 
            // DeviceModelInfoLabel
            // 
            this.DeviceModelInfoLabel.AutoSize = true;
            this.DeviceModelInfoLabel.Location = new System.Drawing.Point(84, 70);
            this.DeviceModelInfoLabel.Name = "DeviceModelInfoLabel";
            this.DeviceModelInfoLabel.Size = new System.Drawing.Size(95, 15);
            this.DeviceModelInfoLabel.TabIndex = 6;
            this.DeviceModelInfoLabel.Text = "LG V60 ThinQ 5G";
            // 
            // DeviceBrandInfoLabel
            // 
            this.DeviceBrandInfoLabel.AutoSize = true;
            this.DeviceBrandInfoLabel.Location = new System.Drawing.Point(82, 46);
            this.DeviceBrandInfoLabel.Name = "DeviceBrandInfoLabel";
            this.DeviceBrandInfoLabel.Size = new System.Drawing.Size(27, 15);
            this.DeviceBrandInfoLabel.TabIndex = 5;
            this.DeviceBrandInfoLabel.Text = "LGE";
            // 
            // AndroidVersionInfoLabel
            // 
            this.AndroidVersionInfoLabel.AutoSize = true;
            this.AndroidVersionInfoLabel.Location = new System.Drawing.Point(97, 22);
            this.AndroidVersionInfoLabel.Name = "AndroidVersionInfoLabel";
            this.AndroidVersionInfoLabel.Size = new System.Drawing.Size(41, 15);
            this.AndroidVersionInfoLabel.TabIndex = 4;
            this.AndroidVersionInfoLabel.Text = "9.0 Pie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "SDK Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Device model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Android version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device brand:";
            // 
            // StreamBtn
            // 
            this.StreamBtn.Location = new System.Drawing.Point(6, 22);
            this.StreamBtn.Name = "StreamBtn";
            this.StreamBtn.Size = new System.Drawing.Size(274, 37);
            this.StreamBtn.TabIndex = 4;
            this.StreamBtn.Text = "Stream";
            this.StreamBtn.UseVisualStyleBackColor = true;
            this.StreamBtn.Click += new System.EventHandler(this.StreamBtn_Click);
            // 
            // EnableTcpConnectionBtn
            // 
            this.EnableTcpConnectionBtn.Location = new System.Drawing.Point(6, 65);
            this.EnableTcpConnectionBtn.Name = "EnableTcpConnectionBtn";
            this.EnableTcpConnectionBtn.Size = new System.Drawing.Size(274, 37);
            this.EnableTcpConnectionBtn.TabIndex = 5;
            this.EnableTcpConnectionBtn.Text = "Enable TCP Connection";
            this.EnableTcpConnectionBtn.UseVisualStyleBackColor = true;
            this.EnableTcpConnectionBtn.Click += new System.EventHandler(this.EnableTcpConnectionBtn_Click);
            // 
            // ConnectionSettingsGroup
            // 
            this.ConnectionSettingsGroup.Controls.Add(this.groupBox7);
            this.ConnectionSettingsGroup.Controls.Add(this.SettingsGroup);
            this.ConnectionSettingsGroup.Controls.Add(this.groupBox5);
            this.ConnectionSettingsGroup.Location = new System.Drawing.Point(218, 12);
            this.ConnectionSettingsGroup.Name = "ConnectionSettingsGroup";
            this.ConnectionSettingsGroup.Size = new System.Drawing.Size(484, 501);
            this.ConnectionSettingsGroup.TabIndex = 6;
            this.ConnectionSettingsGroup.TabStop = false;
            this.ConnectionSettingsGroup.Text = "Connection settings";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.richTextBox1);
            this.groupBox7.Location = new System.Drawing.Point(7, 354);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(471, 141);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Shortcuts";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(458, 113);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // SettingsGroup
            // 
            this.SettingsGroup.Controls.Add(this.AlwaysOnTopCheck);
            this.SettingsGroup.Controls.Add(this.DisableScreensaverCheck);
            this.SettingsGroup.Controls.Add(this.RenderDelayedFramesCheck);
            this.SettingsGroup.Controls.Add(this.ShowTouchesCheck);
            this.SettingsGroup.Controls.Add(this.KeepScreenOffCheck);
            this.SettingsGroup.Controls.Add(this.PreventSleepingCheck);
            this.SettingsGroup.Controls.Add(this.FpsBox);
            this.SettingsGroup.Controls.Add(this.label13);
            this.SettingsGroup.Controls.Add(this.DisableControlsCheck);
            this.SettingsGroup.Controls.Add(this.FullscreenCheck);
            this.SettingsGroup.Controls.Add(this.HideWindowBordersCheck);
            this.SettingsGroup.Controls.Add(this.EnableRecordingCheck);
            this.SettingsGroup.Controls.Add(this.BitrateBox);
            this.SettingsGroup.Controls.Add(this.label12);
            this.SettingsGroup.Location = new System.Drawing.Point(7, 172);
            this.SettingsGroup.Name = "SettingsGroup";
            this.SettingsGroup.Size = new System.Drawing.Size(471, 176);
            this.SettingsGroup.TabIndex = 1;
            this.SettingsGroup.TabStop = false;
            this.SettingsGroup.Text = "Display settings";
            // 
            // AlwaysOnTopCheck
            // 
            this.AlwaysOnTopCheck.AutoSize = true;
            this.AlwaysOnTopCheck.Location = new System.Drawing.Point(227, 149);
            this.AlwaysOnTopCheck.Name = "AlwaysOnTopCheck";
            this.AlwaysOnTopCheck.Size = new System.Drawing.Size(101, 19);
            this.AlwaysOnTopCheck.TabIndex = 13;
            this.AlwaysOnTopCheck.Text = "Always on top";
            this.AlwaysOnTopCheck.UseVisualStyleBackColor = true;
            // 
            // DisableScreensaverCheck
            // 
            this.DisableScreensaverCheck.AutoSize = true;
            this.DisableScreensaverCheck.Checked = true;
            this.DisableScreensaverCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableScreensaverCheck.Location = new System.Drawing.Point(7, 149);
            this.DisableScreensaverCheck.Name = "DisableScreensaverCheck";
            this.DisableScreensaverCheck.Size = new System.Drawing.Size(128, 19);
            this.DisableScreensaverCheck.TabIndex = 12;
            this.DisableScreensaverCheck.Text = "Disable screensaver";
            this.DisableScreensaverCheck.UseVisualStyleBackColor = true;
            // 
            // RenderDelayedFramesCheck
            // 
            this.RenderDelayedFramesCheck.AutoSize = true;
            this.RenderDelayedFramesCheck.Location = new System.Drawing.Point(227, 125);
            this.RenderDelayedFramesCheck.Name = "RenderDelayedFramesCheck";
            this.RenderDelayedFramesCheck.Size = new System.Drawing.Size(146, 19);
            this.RenderDelayedFramesCheck.TabIndex = 11;
            this.RenderDelayedFramesCheck.Text = "Render delayed frames";
            this.RenderDelayedFramesCheck.UseVisualStyleBackColor = true;
            // 
            // ShowTouchesCheck
            // 
            this.ShowTouchesCheck.AutoSize = true;
            this.ShowTouchesCheck.Location = new System.Drawing.Point(227, 49);
            this.ShowTouchesCheck.Name = "ShowTouchesCheck";
            this.ShowTouchesCheck.Size = new System.Drawing.Size(100, 19);
            this.ShowTouchesCheck.TabIndex = 10;
            this.ShowTouchesCheck.Text = "Show touches";
            this.ShowTouchesCheck.UseVisualStyleBackColor = true;
            // 
            // KeepScreenOffCheck
            // 
            this.KeepScreenOffCheck.AutoSize = true;
            this.KeepScreenOffCheck.Checked = true;
            this.KeepScreenOffCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KeepScreenOffCheck.Location = new System.Drawing.Point(7, 98);
            this.KeepScreenOffCheck.Name = "KeepScreenOffCheck";
            this.KeepScreenOffCheck.Size = new System.Drawing.Size(107, 19);
            this.KeepScreenOffCheck.TabIndex = 9;
            this.KeepScreenOffCheck.Text = "Keep screen off";
            this.KeepScreenOffCheck.UseVisualStyleBackColor = true;
            // 
            // PreventSleepingCheck
            // 
            this.PreventSleepingCheck.AutoSize = true;
            this.PreventSleepingCheck.Checked = true;
            this.PreventSleepingCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PreventSleepingCheck.Location = new System.Drawing.Point(7, 48);
            this.PreventSleepingCheck.Name = "PreventSleepingCheck";
            this.PreventSleepingCheck.Size = new System.Drawing.Size(113, 19);
            this.PreventSleepingCheck.TabIndex = 8;
            this.PreventSleepingCheck.Text = "Prevent sleeping";
            this.PreventSleepingCheck.UseVisualStyleBackColor = true;
            // 
            // FpsBox
            // 
            this.FpsBox.Location = new System.Drawing.Point(273, 20);
            this.FpsBox.Name = "FpsBox";
            this.FpsBox.Size = new System.Drawing.Size(76, 23);
            this.FpsBox.TabIndex = 7;
            this.FpsBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Framerate (FPS):";
            // 
            // DisableControlsCheck
            // 
            this.DisableControlsCheck.AutoSize = true;
            this.DisableControlsCheck.Location = new System.Drawing.Point(227, 99);
            this.DisableControlsCheck.Name = "DisableControlsCheck";
            this.DisableControlsCheck.Size = new System.Drawing.Size(110, 19);
            this.DisableControlsCheck.TabIndex = 5;
            this.DisableControlsCheck.Text = "Disable controls";
            this.DisableControlsCheck.UseVisualStyleBackColor = true;
            // 
            // FullscreenCheck
            // 
            this.FullscreenCheck.AutoSize = true;
            this.FullscreenCheck.Location = new System.Drawing.Point(227, 74);
            this.FullscreenCheck.Name = "FullscreenCheck";
            this.FullscreenCheck.Size = new System.Drawing.Size(79, 19);
            this.FullscreenCheck.TabIndex = 4;
            this.FullscreenCheck.Text = "Fullscreen";
            this.FullscreenCheck.UseVisualStyleBackColor = true;
            // 
            // HideWindowBordersCheck
            // 
            this.HideWindowBordersCheck.AutoSize = true;
            this.HideWindowBordersCheck.Location = new System.Drawing.Point(7, 123);
            this.HideWindowBordersCheck.Name = "HideWindowBordersCheck";
            this.HideWindowBordersCheck.Size = new System.Drawing.Size(139, 19);
            this.HideWindowBordersCheck.TabIndex = 3;
            this.HideWindowBordersCheck.Text = "Hide window borders";
            this.HideWindowBordersCheck.UseVisualStyleBackColor = true;
            // 
            // EnableRecordingCheck
            // 
            this.EnableRecordingCheck.AutoSize = true;
            this.EnableRecordingCheck.Location = new System.Drawing.Point(7, 73);
            this.EnableRecordingCheck.Name = "EnableRecordingCheck";
            this.EnableRecordingCheck.Size = new System.Drawing.Size(181, 19);
            this.EnableRecordingCheck.TabIndex = 2;
            this.EnableRecordingCheck.Text = "Enable recording (My Videos)";
            this.EnableRecordingCheck.UseVisualStyleBackColor = true;
            // 
            // BitrateBox
            // 
            this.BitrateBox.Location = new System.Drawing.Point(98, 20);
            this.BitrateBox.Name = "BitrateBox";
            this.BitrateBox.Size = new System.Drawing.Size(70, 23);
            this.BitrateBox.TabIndex = 1;
            this.BitrateBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Bitrate [Mbps]:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.WifiConnectionInfo);
            this.groupBox5.Controls.Add(this.WifiConnectBtn);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.IPBox);
            this.groupBox5.Location = new System.Drawing.Point(7, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(471, 143);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wireless connection";
            // 
            // WifiConnectionInfo
            // 
            this.WifiConnectionInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.WifiConnectionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WifiConnectionInfo.Enabled = false;
            this.WifiConnectionInfo.ForeColor = System.Drawing.Color.DimGray;
            this.WifiConnectionInfo.Location = new System.Drawing.Point(7, 71);
            this.WifiConnectionInfo.Multiline = true;
            this.WifiConnectionInfo.Name = "WifiConnectionInfo";
            this.WifiConnectionInfo.ReadOnly = true;
            this.WifiConnectionInfo.Size = new System.Drawing.Size(458, 66);
            this.WifiConnectionInfo.TabIndex = 3;
            this.WifiConnectionInfo.Text = resources.GetString("WifiConnectionInfo.Text");
            // 
            // WifiConnectBtn
            // 
            this.WifiConnectBtn.Location = new System.Drawing.Point(355, 33);
            this.WifiConnectBtn.Name = "WifiConnectBtn";
            this.WifiConnectBtn.Size = new System.Drawing.Size(110, 32);
            this.WifiConnectBtn.TabIndex = 2;
            this.WifiConnectBtn.Text = "Connect";
            this.WifiConnectBtn.UseVisualStyleBackColor = true;
            this.WifiConnectBtn.Click += new System.EventHandler(this.WifiConnectBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "IP Address:";
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(6, 39);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(343, 23);
            this.IPBox.TabIndex = 0;
            // 
            // ActionsGroup
            // 
            this.ActionsGroup.Controls.Add(this.EnableTcpConnectionBtn);
            this.ActionsGroup.Controls.Add(this.StreamBtn);
            this.ActionsGroup.Location = new System.Drawing.Point(708, 158);
            this.ActionsGroup.Name = "ActionsGroup";
            this.ActionsGroup.Size = new System.Drawing.Size(288, 118);
            this.ActionsGroup.TabIndex = 7;
            this.ActionsGroup.TabStop = false;
            this.ActionsGroup.Text = "Actions";
            // 
            // InstallDevDriversBtn
            // 
            this.InstallDevDriversBtn.Location = new System.Drawing.Point(714, 325);
            this.InstallDevDriversBtn.Name = "InstallDevDriversBtn";
            this.InstallDevDriversBtn.Size = new System.Drawing.Size(274, 37);
            this.InstallDevDriversBtn.TabIndex = 6;
            this.InstallDevDriversBtn.Text = "Install developer drivers";
            this.InstallDevDriversBtn.UseVisualStyleBackColor = true;
            this.InstallDevDriversBtn.Click += new System.EventHandler(this.InstallDevDriversBtn_Click);
            // 
            // KillAdbServerBtn
            // 
            this.KillAdbServerBtn.Location = new System.Drawing.Point(714, 282);
            this.KillAdbServerBtn.Name = "KillAdbServerBtn";
            this.KillAdbServerBtn.Size = new System.Drawing.Size(274, 37);
            this.KillAdbServerBtn.TabIndex = 0;
            this.KillAdbServerBtn.Text = "Restart engine";
            this.KillAdbServerBtn.UseVisualStyleBackColor = true;
            this.KillAdbServerBtn.Click += new System.EventHandler(this.KillAdbServerBtn_Click);
            // 
            // RepoUri
            // 
            this.RepoUri.AutoSize = true;
            this.RepoUri.Location = new System.Drawing.Point(621, 545);
            this.RepoUri.Name = "RepoUri";
            this.RepoUri.Size = new System.Drawing.Size(375, 15);
            this.RepoUri.TabIndex = 8;
            this.RepoUri.TabStop = true;
            this.RepoUri.Text = "Project repository - https://github.com/EquablePanic4/Remotephone";
            this.RepoUri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RepoUri_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Author: Bartosz Miąskowski";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(714, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RepoUri);
            this.Controls.Add(this.KillAdbServerBtn);
            this.Controls.Add(this.InstallDevDriversBtn);
            this.Controls.Add(this.ActionsGroup);
            this.Controls.Add(this.ConnectionSettingsGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Remotephone [v1.0]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ConnectionSettingsGroup.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.SettingsGroup.ResumeLayout(false);
            this.SettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FpsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ActionsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvailbleDevicesBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RefreshDeviceBtn;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AccessLevelInfoLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label SdkLevelInfoLabel;
        private System.Windows.Forms.Label DeviceModelInfoLabel;
        private System.Windows.Forms.Label DeviceBrandInfoLabel;
        private System.Windows.Forms.Label AndroidVersionInfoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StreamBtn;
        private System.Windows.Forms.Button EnableTcpConnectionBtn;
        private System.Windows.Forms.GroupBox ConnectionSettingsGroup;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox SettingsGroup;
        private System.Windows.Forms.CheckBox AlwaysOnTopCheck;
        private System.Windows.Forms.CheckBox DisableScreensaverCheck;
        private System.Windows.Forms.CheckBox RenderDelayedFramesCheck;
        private System.Windows.Forms.CheckBox ShowTouchesCheck;
        private System.Windows.Forms.CheckBox KeepScreenOffCheck;
        private System.Windows.Forms.CheckBox PreventSleepingCheck;
        private System.Windows.Forms.NumericUpDown FpsBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox DisableControlsCheck;
        private System.Windows.Forms.CheckBox FullscreenCheck;
        private System.Windows.Forms.CheckBox HideWindowBordersCheck;
        private System.Windows.Forms.CheckBox EnableRecordingCheck;
        private System.Windows.Forms.NumericUpDown BitrateBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox WifiConnectionInfo;
        private System.Windows.Forms.Button WifiConnectBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.GroupBox ActionsGroup;
        private System.Windows.Forms.Button KillAdbServerBtn;
        private System.Windows.Forms.Button InstallDevDriversBtn;
        private System.Windows.Forms.LinkLabel RepoUri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


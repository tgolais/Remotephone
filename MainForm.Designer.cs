
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ConnectionSettingsGroup = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.WifiConnectionInfo = new System.Windows.Forms.TextBox();
            this.WifiConnectBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ActionsGroup = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ConnectionSettingsGroup.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.ActionsGroup.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConnectionSettingsGroup
            // 
            this.ConnectionSettingsGroup.Controls.Add(this.groupBox7);
            this.ConnectionSettingsGroup.Controls.Add(this.groupBox6);
            this.ConnectionSettingsGroup.Controls.Add(this.groupBox5);
            this.ConnectionSettingsGroup.Enabled = false;
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox10);
            this.groupBox6.Controls.Add(this.checkBox9);
            this.groupBox6.Controls.Add(this.checkBox8);
            this.groupBox6.Controls.Add(this.checkBox7);
            this.groupBox6.Controls.Add(this.checkBox6);
            this.groupBox6.Controls.Add(this.checkBox5);
            this.groupBox6.Controls.Add(this.numericUpDown2);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.checkBox4);
            this.groupBox6.Controls.Add(this.checkBox3);
            this.groupBox6.Controls.Add(this.checkBox2);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.numericUpDown1);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(7, 172);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(471, 176);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Display settings";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(227, 148);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(101, 19);
            this.checkBox10.TabIndex = 13;
            this.checkBox10.Text = "Always on top";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(7, 149);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(128, 19);
            this.checkBox9.TabIndex = 12;
            this.checkBox9.Text = "Disable screensaver";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(227, 122);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(146, 19);
            this.checkBox8.TabIndex = 11;
            this.checkBox8.Text = "Render delayed frames";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(227, 49);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(100, 19);
            this.checkBox7.TabIndex = 10;
            this.checkBox7.Text = "Show touches";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 98);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(107, 19);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "Keep screen off";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 48);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 19);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "Prevent sleeping";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(273, 20);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 23);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
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
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(227, 99);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(110, 19);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Disable controls";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(227, 74);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 19);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Fullscreen";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 123);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(139, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Hide window borders";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Enable recording";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(98, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
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
            this.groupBox5.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 23);
            this.textBox1.TabIndex = 0;
            // 
            // ActionsGroup
            // 
            this.ActionsGroup.Controls.Add(this.button3);
            this.ActionsGroup.Controls.Add(this.button2);
            this.ActionsGroup.Controls.Add(this.button1);
            this.ActionsGroup.Location = new System.Drawing.Point(708, 158);
            this.ActionsGroup.Name = "ActionsGroup";
            this.ActionsGroup.Size = new System.Drawing.Size(288, 355);
            this.ActionsGroup.TabIndex = 7;
            this.ActionsGroup.TabStop = false;
            this.ActionsGroup.Text = "Actions";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 546);
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ActionsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox ConnectionSettingsGroup;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox WifiConnectionInfo;
        private System.Windows.Forms.Button WifiConnectBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox ActionsGroup;
        private System.Windows.Forms.Button button3;
    }
}


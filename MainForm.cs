using Remotephone.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remotephone
{
    public partial class MainForm : Form
    {
        private readonly string _appDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Codli", @"Remotephone\");
        private List<PlayStoreDevice> _knownDevices;

        public MainForm()
        {
            //Looking for app directory
            if (!Directory.Exists(_appDirectory))
            {
                Directory.CreateDirectory(_appDirectory);

                var zipPath = Path.Combine(_appDirectory, "scrcpy_pack.zip");
                File.WriteAllBytes(zipPath, Properties.Resources.scrcpy);
                ZipFile.ExtractToDirectory(zipPath, _appDirectory);
                File.Delete(zipPath);
            }

            //Loading known devices into memory
            _knownDevices = PlayStoreDevice.ParseCsv(Properties.Resources.supported_devices).ToList();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Setting progress min and max values
            Progress.Minimum = 0;
            Progress.Maximum = 100;

            //Disabling initial disabled boxes
            DisableActionGroups();

            //Earsing mockup data
            SetPhoneInfo();

            //Initializing Universal Toolkit Engine
            UniversalToolkitEngine.Initialize((tuple) => Extensions.Execute(tuple.command, tuple.wait, tuple.executable), Path.Combine(_appDirectory, "adb.exe"), _knownDevices);
        }

        private void RefreshDeviceBtn_Click(object sender, EventArgs e)
        {
            SetProgress(10);

            new Thread(() =>
            {
                DisableActionGroups();
                try
                {
                    var devices = UniversalToolkitEngine.ConnectedDevicesDetails();
                    SetProgress(80);

                    AvailbleDevicesBox.EasyInvoke(() =>
                    {
                        if (devices?.Any() ?? false)
                            AvailbleDevicesBox.DataSource = devices;
                        else
                            AvailbleDevicesBox.DataSource = new List<ConnectedDevice>();
                    });
                }

                catch
                {
                    MessageBox.Show("An error occured when trying to get connected devices", "Error");
                }

                finally
                {
                    EnableActionGroups();
                    SetProgress(100);
                }
            }).Start();
        }

        private void SetProgress(int progress)
        {
            Progress.EasyInvoke(() =>
            {
                Progress.Value = progress;
            });

            if (progress >= 100)
            {
                new Thread(() =>
                {
                    Thread.Sleep(1000);
                    SetProgress(0);
                }).Start();
            }
        }

        private void DisableActionGroups()
        {
            ActionsGroup.EasyInvoke(() => ActionsGroup.Enabled = false);
            ConnectionSettingsGroup.EasyInvoke(() => ConnectionSettingsGroup.Enabled = false);
        }

        private void EnableActionGroups()
        {
            ActionsGroup.EasyInvoke(() => ActionsGroup.Enabled = true);
            ConnectionSettingsGroup.EasyInvoke(() => ConnectionSettingsGroup.Enabled = true);
        }

        private void SetPhoneInfo(ConnectedDevice device)
            => SetPhoneInfo(device.AndroidVersion, device.Brand, device.Name, device.Sdk, device.Magisk);

        private void SetPhoneInfo(string androidVersion = "", string deviceBrand = "", string deviceModel = "", int sdkLevel = 0, bool? su = null)
        {
            AndroidVersionInfoLabel.EasyInvoke(() => AndroidVersionInfoLabel.Text = androidVersion);
            DeviceBrandInfoLabel.EasyInvoke(() => DeviceBrandInfoLabel.Text = deviceBrand);
            DeviceModelInfoLabel.EasyInvoke(() => DeviceModelInfoLabel.Text = deviceModel);
            SdkLevelInfoLabel.EasyInvoke(() => SdkLevelInfoLabel.Text = sdkLevel > 0 ? sdkLevel.ToString() : String.Empty);
            AccessLevelInfoLabel.EasyInvoke(() =>
            {
                if (su is not null)
                    AccessLevelInfoLabel.Text = (bool)su ? "Availble" : "Not availble or denied";
                else
                    AccessLevelInfoLabel.Text = String.Empty;
            });
        }

        private void LockForm()
            => Controls.OfType<GroupBox>().ForEach(e => e.EasyInvoke(() => e.Enabled = false));

        private void UnlockForm()
            => Controls.OfType<GroupBox>().ForEach(e => e.EasyInvoke(() => e.Enabled = true));

        private void SetActiveDevice(ConnectedDevice device)
        {
            SetPhoneInfo(device);
        }

        private void AvailbleDevicesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailbleDevicesBox.SelectedIndex >= 0)
                SetActiveDevice(AvailbleDevicesBox.SelectedItem as ConnectedDevice);
        }
    }
}

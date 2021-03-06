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

        #region Initialization

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
            //DisableActionGroups();

            //Earsing mockup data
            SetPhoneInfo();

            //Initializing Universal Toolkit Engine
            UniversalToolkitEngine.Initialize((tuple) => Extensions.Execute(tuple.command, tuple.wait, tuple.executable), Path.Combine(_appDirectory, "adb.exe"), _knownDevices);
        }

        #endregion

        #region Thread safe UI methods

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

        #endregion

        #region UI Event Handlers

        private void AvailbleDevicesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailbleDevicesBox.SelectedIndex >= 0)
                SetActiveDevice(AvailbleDevicesBox.SelectedItem as ConnectedDevice);
        }

        private void InstallDevDriversBtn_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                var dir = Path.Combine(Path.GetTempPath(), $"codli-{Guid.NewGuid()}\\");
                Directory.CreateDirectory(dir);
                var exe = Path.Combine(dir, "dev_drivers.exe");
                File.WriteAllBytes(exe, Properties.Resources.Universal_ADB_Driver_v6_0);

                exe.Execute(false, "explorer.exe", true);
            }).Start();
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

        private void StreamBtn_Click(object sender, EventArgs e)
        {
            SetProgress(10);

            try
            {
                var query = BuildQuery();

                SetProgress(50);

                new Thread(() =>
                {
                    query.Execute(false, Path.Combine(_appDirectory, "scrcpy.exe"), false);

                    SetProgress(100);
                }).Start();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }

            finally
            {
                SetProgress(100);
            }

        }

        private void EnableTcpConnectionBtn_Click(object sender, EventArgs e)
        {
            SetProgress(10);
            try
            {
                var selectedPhone = AvailbleDevicesBox.SelectedItem as ConnectedDevice;
                if (selectedPhone is null)
                    throw new NullReferenceException("Couldn't load selected device data");

                new Thread(() =>
                {
                    if (UniversalToolkitEngine.EnableTcpConnection(selectedPhone.AdbId))
                    {
                        SetProgress(100);
                        MessageBox.Show("Now you can connect device within it's IP Address, device is listening on port 5555", "Enabled TCP Connection");
                    }

                    else
                    {
                        SetProgress(100);
                        MessageBox.Show("An error occured while attempting to start TCP listening on port 5555", "Error");
                    }
                }).Start();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }

            finally
            {
                SetProgress(100);
            }
        }

        private void KillAdbServerBtn_Click(object sender, EventArgs e)
        {
            SetProgress(10);

            new Thread(() =>
            {
                DisableActionGroups();
                UniversalToolkitEngine.KillAdb();
                EnableActionGroups();
                SetProgress(100);
            });
        }

        #endregion

        #region Engine methods

        /// <summary>
        /// This method must be executed from UI thread!
        /// </summary>
        /// <returns></returns>
        private string BuildQuery()
        {
            var str = new List<string>();
            var selectedDevice = AvailbleDevicesBox.SelectedItem as ConnectedDevice;
            if (selectedDevice is null)
                throw new NullReferenceException("Couldn't load selected phone data");

            str.Add($"--serial {selectedDevice.AdbId}");
            str.Add($"--window-title \"Remotephone - {selectedDevice.Name} [Android {selectedDevice.AndroidVersion}]{(selectedDevice.Magisk ? " ROOTED" : String.Empty)}\"");

            if (BitrateBox.Value > 0 && BitrateBox.Value != 8)
                str.Add($"--bit-rate {BitrateBox.Value}M");

            if (FpsBox.Value > 0 && FpsBox.Enabled)
                str.Add($"--max-fps {FpsBox.Value}");

            if (PreventSleepingCheck.Checked)
                str.Add("--stay-awake");

            if (EnableRecordingCheck.Checked)
            {
                var videoDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "Remotephone");
                if (!Directory.Exists(videoDir))
                    Directory.CreateDirectory(videoDir);

                str.Add($"--record \"{Path.Combine(videoDir, $"{selectedDevice.Name} {DateTime.Now:yyyy-MM-dd-HH-mm-ss}.mp4")}\"");
            }

            if (KeepScreenOffCheck.Checked)
                str.Add("--turn-screen-off");

            if (HideWindowBordersCheck.Checked)
                str.Add("--window-borderless");

            if (DisableScreensaverCheck.Checked)
                str.Add("--disable-screensaver");

            if (ShowTouchesCheck.Checked)
                str.Add("--show-touches");

            if (FullscreenCheck.Checked)
                str.Add("--fullscreen");

            if (DisableControlsCheck.Checked)
                str.Add("--no-control");

            if (RenderDelayedFramesCheck.Checked)
                str.Add("--render-expired-frames");

            if (AlwaysOnTopCheck.Checked)
                str.Add("--always-on-top");

            return str.StringJoin(" ");
        }

        #endregion
    }
}

using Remotephone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remotephone
{
    static class UniversalToolkitEngine
    {
        private static string _adb;
        private static string _shell = Environment.OSVersion.Platform == PlatformID.Win32NT ? "cmd.exe" : "/bin/bash";
        private static Func<string, bool, string, string> _executor;
        private static List<PlayStoreDevice> _devices;

        public static void Initialize(Func<(string command, bool wait, string executable), string> executor, string adbPath, List<PlayStoreDevice> devices)
            => (_executor, _adb, _devices) = ((x, y, z) => executor((x, y, z)), adbPath, devices);

        public static string DeviceModel(string deviceId = "")
        {
            var output = _executor($"{(!String.IsNullOrEmpty(deviceId) ? $"-s {deviceId} " : String.Empty)}shell getprop ro.product.model", true, _adb).Replace("\r", "").Replace("\n", "");
            if (output.Contains("adb.exe") || String.IsNullOrWhiteSpace(output))
                return String.Empty;

            return output;
        }

        public static int DeviceSdkLevel(string deviceId = "")
        {
            var output = _executor($"{(!String.IsNullOrEmpty(deviceId) ? $"-s {deviceId} " : String.Empty)}shell getprop ro.build.version.sdk", true, _adb).Replace("\r", "").Replace("\n", "").Replace(" ", "");
            var sdkLevel = 0;
            var sdkLevelResult = Int32.TryParse(output, out sdkLevel);

            return sdkLevel;
        }

        public static bool DeviceSuState(string deviceId)
        {
            var computedCommand = $"{(!String.IsNullOrEmpty(deviceId) ? $"-s {deviceId} " : String.Empty)}shell \"su -c 'getprop ro.build.version.sdk'\"";
            var rawOutput = _executor(computedCommand, true, _adb);
            var output = rawOutput.Replace("\r", "").Replace("\n", "").Replace(" ", "");
            return Int32.TryParse(output, out int x);
        }

        public static List<string> ConnectedDevices()
            => _executor("devices", true, _adb).Split('\n').Skip(1).Select(s => s.Replace("\r", null)).Select(s => s.TakeWhile(e => e != '\t').StringJoin(""))
            .Where(e => !String.IsNullOrWhiteSpace(e)).ToList();

        private static string AndroidVersion(int sdkLevel)
            => sdkLevel switch
            {
                8 => "2.2 Froyo",
                9 or 10 => "2.3 Gingearbread",
                11 or 12 or 13 => $"3.{sdkLevel - 11} Honeycomb",
                14 or 15 => "4.0 Ice Cream Sandwich",
                16 or 17 or 18 => $"4.{sdkLevel - 15} Jelly Bean",
                19 or 20 => "4.4 KitKat",
                21 or 22 => $"5.{sdkLevel - 21} Lollipop",
                23 => "6.0 Marshmallow",
                24 or 25 => $"7.{sdkLevel - 24} Nougat",
                26 or 27 => $"8.{sdkLevel - 26} Oreo",
                28 => "9.0 Pie",
                29 or 30 or 31 => $"{sdkLevel - 19}",
                _ => "Unknown"
            };

        public static List<ConnectedDevice> ConnectedDevicesDetails()
        {
            var syncCollection = new SynchronizedCollection<ConnectedDevice>();
            Parallel.ForEach(ConnectedDevices(), (id) =>
            {
                var sdkLevel = DeviceSdkLevel(id);
                var model = DeviceModel(id);
                var phoneInfo = _devices.Where(e => e.Model == model).FirstOrDefault();

                syncCollection.Add(new()
                {
                    AndroidVersion = AndroidVersion(sdkLevel),
                    Brand = phoneInfo?.Brand ?? "Unknown",
                    Name = phoneInfo?.Name ?? model,
                    Sdk = sdkLevel,
                    Magisk = DeviceSuState(id)

                });
            });

            return syncCollection.ToList();
        }
    }
}

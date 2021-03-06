using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remotephone.Models
{
    class ConnectedDevice
    {
        public string Name { get; init; }
        public string Brand { get; init; }
        public string AndroidVersion { get; init; }
        public int Sdk { get; init; }
        public bool Magisk { get; init; }
        public string AdbId { get; set; }

        public ConnectedDevice()
        {

        }

        public ConnectedDevice(string name, string brand, string androidVersion, int sdk, bool magisk, string adbId)
            => (Name, Brand, AndroidVersion, Sdk, Magisk, AdbId) = (name, brand, androidVersion, sdk, magisk, adbId);

        public override string ToString()
            => Name;
    }
}

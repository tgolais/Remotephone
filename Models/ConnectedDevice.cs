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

        public ConnectedDevice()
        {

        }

        public ConnectedDevice(string name, string brand, string androidVersion, int sdk, bool magisk)
            => (Name, Brand, AndroidVersion, Sdk, Magisk) = (name, brand, androidVersion, sdk, magisk);

        public override string ToString()
            => Name;
    }
}

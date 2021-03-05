using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remotephone.Models
{
    class PlayStoreDevice
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string CodeName { get; set; }
        public string Model { get; set; }

        public PlayStoreDevice()
        {

        }

        public PlayStoreDevice(string brand, string name, string codeName, string model)
            => (Brand, Name, CodeName, Model) = (brand, name, codeName, model);

        public PlayStoreDevice(string csvLine)
        {
            var arr = csvLine.Split(',');
            Brand = arr[0];
            Name = arr[1];
            CodeName = arr[2];
            Model = arr[3];
        }

        public static IEnumerable<PlayStoreDevice> ParseCsv(string csv)
        {
            foreach (var line in csv.Replace("\r", null).Split('\n'))
                if (!String.IsNullOrWhiteSpace(line))
                    yield return new(line);
        }
    }
}

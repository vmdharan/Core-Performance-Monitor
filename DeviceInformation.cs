using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Performance_Monitor
{
    internal class DeviceInformation
    {
        public string DeviceName { get; set; }
        public string OperatingSystem { get; set; }
        public string OSVersion { get; set; }

        public DeviceInformation(string deviceName, string operatingSystem, string oSVersion)
        {
            DeviceName = deviceName;
            OperatingSystem = operatingSystem;
            OSVersion = oSVersion;
        }
    }
}

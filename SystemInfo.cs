using System.Management;

namespace Core_Performance_Monitor
{
    internal class SystemInfo
    {
        // Query information about the processor.
        ManagementClass managementClassProcessor = new("Win32_Processor");

        // Query information about the cache.
        ManagementClass managementClassCacheMemory = new ManagementClass("Win32_CacheMemory");

        // Query information about the operating system.
        ObjectQuery objectqueryW32OS = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

        // Query information about the video card.
        ObjectQuery objectQueryW32VC = new ObjectQuery("SELECT * FROM Win32_VideoController");

        private const int defaultFrequency = 1000;

        public SystemInfo()
        {

        }

        public List<GraphicsInformation> GetGraphicsInformation()
        {
            using (ManagementObjectCollection mocW32VC = new ManagementObjectSearcher(objectQueryW32VC).Get())
            {
                List<GraphicsInformation> result = new List<GraphicsInformation>();
                foreach (ManagementObject mo in mocW32VC)
                {
                    string GPUInfoVal = (string) mo.Properties["Name"].Value;
                    string GPUInfoVer = (string) mo.Properties["DriverVersion"].Value;

                    result.Add(new GraphicsInformation(GPUInfoVal, GPUInfoVer));
                }
                return result;
            }
                
        }

        public CacheInformation GetCacheInformation()
        {
            const ushort CACHE_LEVEL_1 = 1;
            const ushort CACHE_LEVEL_2 = 2;
            const ushort CACHE_LEVEL_3 = 3;
            const ushort CACHE_LEVEL_1_CODE = 3;
            const ushort CACHE_LEVEL_2_CODE = 4;
            const ushort CACHE_LEVEL_3_CODE = 5;

            ManagementObjectCollection mocW32CacheMemory = managementClassCacheMemory.GetInstances();

            List<CacheMemory> caches =
            [
                .. mocW32CacheMemory.Cast<ManagementObject>()
                            .Where(managementObject => (ushort)managementObject.Properties["Level"].Value == (ushort)CACHE_LEVEL_1_CODE)
                            .Select(managementObject => new CacheMemory(CACHE_LEVEL_1, (uint)managementObject.Properties["MaxCacheSize"].Value)),
                .. mocW32CacheMemory.Cast<ManagementObject>()
                            .Where(managementObject => (ushort)managementObject.Properties["Level"].Value == (ushort)CACHE_LEVEL_2_CODE)
                            .Select(managementObject => new CacheMemory(CACHE_LEVEL_2, (uint)managementObject.Properties["MaxCacheSize"].Value)),
                .. mocW32CacheMemory.Cast<ManagementObject>()
                            .Where(managementObject => (ushort)managementObject.Properties["Level"].Value == (ushort)CACHE_LEVEL_3_CODE)
                            .Select(managementObject => new CacheMemory(CACHE_LEVEL_3, (uint)managementObject.Properties["MaxCacheSize"].Value)),
            ];

            mocW32CacheMemory.Dispose();

            return new CacheInformation(
                caches.Where(c => c.CacheLevel == CACHE_LEVEL_1).Select(s => s.CacheSize).Sum(size => size),
                caches.Where(c => c.CacheLevel == CACHE_LEVEL_2).Select(s => s.CacheSize).Sum(size => size),
                caches.Where(c => c.CacheLevel == CACHE_LEVEL_3).Select(s => s.CacheSize).Sum(size => size)
                );
        }

        public MemoryInformation GetMemoryInformation()
        {
            using (ManagementObjectCollection mocW32OS = new ManagementObjectSearcher(objectqueryW32OS).Get())
            {
                ulong freeMemory = (ulong)mocW32OS.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["FreePhysicalMemory"]).First().Value;
                ulong totalMemory = (ulong)mocW32OS.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["TotalVisibleMemorySize"]).First().Value;
                ulong freeVirtualMemory = (ulong)mocW32OS.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["FreeVirtualMemory"]).First().Value;
                ulong totalVirtualMemory = (ulong)mocW32OS.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["TotalVirtualMemorySize"]).First().Value;
                ulong freeSpacePaging = (ulong)mocW32OS.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["FreeSpaceInPagingFiles"]).First().Value;
                ulong sizeStoredPaging = (ulong)mocW32OS.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["SizeStoredInPagingFiles"]).First().Value;

                return new MemoryInformation(
                    freeMemory,
                    totalMemory,
                    freeVirtualMemory,
                    totalVirtualMemory,
                    freeSpacePaging,
                    sizeStoredPaging
                );
            }
        }

        public ProcessorInformation GetProcessorInformation()
        {
            ManagementObjectCollection mocW32Processor = managementClassProcessor.GetInstances();

            var processorType = (string)mocW32Processor.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["Name"]).First().Value;
            var physicalCores = (uint)mocW32Processor.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["NumberOfCores"]).First().Value;
            var logicalCores = (uint)mocW32Processor.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["NumberOfLogicalProcessors"]).First().Value;

            mocW32Processor.Dispose();

            return new ProcessorInformation(processorType, physicalCores, logicalCores);
        }

        public DeviceInformation GetDeviceInformation()
        {
            ManagementObjectSearcher mosW32OS = new ManagementObjectSearcher(objectqueryW32OS);
            ManagementObjectCollection mocW32OS = mosW32OS.Get();

            var deviceName = (string) Environment.MachineName;
            var operatingSystem = (string)mocW32OS.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["Caption"]).First().Value;
            var osVersion = (string) Environment.OSVersion.Version.ToString();

            mocW32OS.Dispose();
            mosW32OS.Dispose();

            return new DeviceInformation(deviceName, operatingSystem, osVersion);
        }

        public ChronoInformation GetChronoInformation()
        {
            using(ManagementObjectCollection mocW32OS = new ManagementObjectSearcher(objectqueryW32OS).Get())
            {
                string lastBootUpTime = (string)mocW32OS.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["LastBootUpTime"]).First().Value;
                string localDateTime = (string)mocW32OS.Cast<ManagementObject>().Select(managementObject => managementObject.Properties["LocalDateTime"]).First().Value;
                
                return new ChronoInformation(ManagementDateTimeConverter.ToDateTime(lastBootUpTime).ToString(), ManagementDateTimeConverter.ToDateTime(localDateTime).ToString(), defaultFrequency);
            }

            
        }

        public void queryInfo()
        {
            ManagementObjectCollection mocW32Processor = managementClassProcessor.GetInstances();

            // Loop and print out processor information.
            foreach (ManagementObject managementObject in mocW32Processor)
            {
                Console.WriteLine(managementObject.Properties.ToString());
            }

            // L2CacheSize
            // L3CacheSize
            // Name
            // NumberOfCores
            // NumberOfLogicalProcessors
            // SystemName
            // TheadCount
            // CurrentClockSpeed








            // Loop and print out cache memory information.
            //foreach (ManagementObject managementObject in mocW32CacheMemory)
            //{
            //    Console.WriteLine(managementObject.Properties.ToString());
            //}

            ManagementObjectSearcher mosW32OS = new ManagementObjectSearcher(objectqueryW32OS);
            ManagementObjectCollection mocW32OS = mosW32OS.Get();

            // Loop and print out OS information.
            foreach (ManagementObject managementObject in mocW32OS)
            {
                Console.WriteLine(managementObject.Properties.ToString());
            }

            // BuildNumber
            // Caption

            // LastBootUpTime
            // LocalDateTime
            // OSArchitecture

            // Version

            ManagementObjectSearcher mosW32VC = new ManagementObjectSearcher(objectQueryW32VC);
            ManagementObjectCollection mocW32VC = mosW32VC.Get();

            // Loop and print out VC information.
            foreach (ManagementObject managementObject in mocW32VC)
            {
                Console.WriteLine(managementObject.Properties.ToString());
            }
        }
    }
}

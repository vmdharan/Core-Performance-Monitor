using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Performance_Monitor
{
    internal class MemoryInformation
    {
        public ulong FreeMemory { get; set; }
        public ulong TotalMemory { get; set; }
        public ulong FreeVirtualMemory { get; set; }
        public ulong TotalVirtualMemory { get; set; }
        public ulong FreeSpacePaging { get; set; }
        public ulong SizeStoredPaging { get; set; }

        public string FreeMemorySizeUnits { get; set; }
        public string TotalMemorySizeUnits { get; set; }
        public string FreeVirtualMemorySizeUnits { get; set; }
        public string TotalVirtualMemorySizeUnits { get; set; }
        public string FreeSpacePagingSizeUnits { get; set; }
        public string SizeStoredPagingSizeUnits { get; set; }

        private const int MB_THRESHOLD = 1024;
        private const string MEGABYTES = "MB";
        private const string KILOBYTES = "KB";

        public MemoryInformation(ulong freeMemory, ulong totalMemory, ulong freeVirtualMemory, ulong totalVirtualMemory,
            ulong freeSpacePaging, ulong sizeStoredPaging)
        {
            FreeMemorySizeUnits = GetSizeUnits(freeMemory);
            TotalMemorySizeUnits = GetSizeUnits(totalMemory);
            FreeVirtualMemorySizeUnits = GetSizeUnits(freeVirtualMemory);
            TotalVirtualMemorySizeUnits = GetSizeUnits(totalVirtualMemory);
            FreeSpacePagingSizeUnits = GetSizeUnits(freeSpacePaging);
            SizeStoredPagingSizeUnits = GetSizeUnits(sizeStoredPaging);

            FreeMemory = GetSizeWRTSizeUnits(freeMemory);
            TotalMemory = GetSizeWRTSizeUnits(totalMemory);
            FreeVirtualMemory = GetSizeWRTSizeUnits(freeVirtualMemory);
            TotalVirtualMemory = GetSizeWRTSizeUnits(totalVirtualMemory);
            FreeSpacePaging = GetSizeWRTSizeUnits(freeSpacePaging);
            SizeStoredPaging = GetSizeWRTSizeUnits(sizeStoredPaging);
        }

        private string GetSizeUnits(ulong size)
        {
            return size > MB_THRESHOLD ? MEGABYTES : KILOBYTES;
        }

        private ulong GetSizeWRTSizeUnits(ulong size)
        {
            return size > MB_THRESHOLD ? size / MB_THRESHOLD : size;
        }
    }
}

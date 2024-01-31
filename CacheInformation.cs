using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Performance_Monitor
{
    internal class CacheInformation
    {
        public long L1CacheSize { get; set; }
        public long L2CacheSize { get; set; }
        public long L3CacheSize { get; set; }

        public string L1SizeUnits { get; set; }
        public string L2SizeUnits { get; set; }
        public string L3SizeUnits { get; set; }

        private const int MB_THRESHOLD = 1024;
        private const string MEGABYTES = "MB";
        private const string KILOBYTES = "KB";

        public CacheInformation(long l1CacheSize, long l2CacheSize, long l3CacheSize)
        {
            L1SizeUnits = GetSizeUnits(l1CacheSize);
            L2SizeUnits = GetSizeUnits(l2CacheSize);
            L3SizeUnits = GetSizeUnits(l3CacheSize);

            L1CacheSize = GetSizeWRTSizeUnits(l1CacheSize);
            L2CacheSize = GetSizeWRTSizeUnits(l2CacheSize);
            L3CacheSize = GetSizeWRTSizeUnits(l3CacheSize);
        }

        private string GetSizeUnits(long size)
        {
            return size > MB_THRESHOLD ? MEGABYTES : KILOBYTES;
        }

        private long GetSizeWRTSizeUnits(long size)
        {
            return size > MB_THRESHOLD ? size / MB_THRESHOLD : size;
        }
    }

    public struct CacheMemory
    {
        public ushort CacheLevel;
        public uint CacheSize;

        public CacheMemory(ushort cacheLevel, uint cacheSize)
        {
            CacheLevel = cacheLevel;
            CacheSize = cacheSize;
        }
    };
}

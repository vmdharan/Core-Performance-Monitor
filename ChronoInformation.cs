using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Performance_Monitor
{
    internal class ChronoInformation
    {
        public string LastBootUpTime { get; set; }
        public string LocalDateTime { get; set; }
        public int RefreshFrequency { get; set; }

        public ChronoInformation(string lastBootUpTime, string localDateTime, int refreshFrequency)
        {
            LastBootUpTime = lastBootUpTime;
            LocalDateTime = localDateTime;
            RefreshFrequency = refreshFrequency;
        }
    }
}

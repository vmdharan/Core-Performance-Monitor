using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Performance_Monitor
{
    internal class ProcessorInformation
    {
        public string ProcessorType { get; set; }
        public uint PhysicalCores { get; set; }
        public uint LogicalCores { get; set; }

        public ProcessorInformation(string processorType, uint physicalCores, uint logicalCores) {
            ProcessorType = processorType;
            PhysicalCores = physicalCores;
            LogicalCores = logicalCores;
        }
    }
}

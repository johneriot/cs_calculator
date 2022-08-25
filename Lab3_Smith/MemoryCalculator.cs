using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Smith
{
    class MemoryCalculator : Calculator
    {

        public double memoryValue;

        public MemoryCalculator()
        {
            this.memoryValue = memoryValue;
        }


        public void MemoryStore(double displayValue)
        {
            memoryValue = displayValue;
        }

        public double MemoryRecall()
        {
            return memoryValue;
        }

        public double MemoryAdd(double displayValue)
        {
            return memoryValue + displayValue;
        }

        public void MemoryClear()
        {
            memoryValue = 0;
        }
    }
}

using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utility
{
    public class DayOfYear
    {
        public DayOfYear(byte month, byte day)
        {
            Month = month;
            Day = day;
        }
        
        [Number(NumberType.Byte, Name = "Month")]
        public byte Month { get; set; }

        [Number(NumberType.Byte, Name = "Day")]
        public byte Day { get; set; }
        
    }
}

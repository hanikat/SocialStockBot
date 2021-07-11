using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utility
{
    public class TimeOfDay
    {
        public TimeOfDay(byte hours, byte minutes, byte seconds, short milliSeconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            MilliSeconds = milliSeconds;

        }

        [Number(NumberType.Byte, Name = "Hours")]
        public byte Hours { get; set; }

        [Number(NumberType.Byte, Name = "Minutes")]
        public byte Minutes { get; set; }

        [Number(NumberType.Byte, Name = "Seconds")]
        public byte Seconds { get; set; }

        [Number(NumberType.Short, Name = "MilliSeconds")]
        public short MilliSeconds { get; set; }
    }
}

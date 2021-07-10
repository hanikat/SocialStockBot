using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class TimeBasedExitCondition
    {
        [Date(Format = "date_time")]
        public DateTime ExitTimestamp { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockMarket
    {
        public string MIC { get; set; }
        public DateTime OpenAt { get; set; }
        public DateTime CloseAt { get; set; }
        public IEnumerable<DateTime> Holidays { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
    }
}

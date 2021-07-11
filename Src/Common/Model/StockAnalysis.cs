using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockAnalysis
    {
        public int AnalyzerId { get; set; }
        public StockAnalyzer StockAnalyzer { get; set; }
        public string StockTicker { get; set; }
        public DateTime TimeStamp { get; set; }
        public byte Rating { get; set; }
    }
}

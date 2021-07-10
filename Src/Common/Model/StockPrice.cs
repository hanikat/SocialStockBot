using Common.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockPrice
    {
        public Keyword StockTicker { get; set; }
        public DateTime Timestamp { get; set; }
        public double CurrentPrice { get; set; }
        public double PE { get; set; }
    }
}

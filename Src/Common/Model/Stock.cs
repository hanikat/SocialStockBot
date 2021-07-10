using Common.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Stock
    {
        public Keyword StockTicker { get; set; }
        public Keyword StockExchangeMIC { get; set; }
        public string StockName { get; set; }
        public double CompanyValue { get; set; }
        public DateTime LastUpdatedTimestamp { get; set; }
    }
}

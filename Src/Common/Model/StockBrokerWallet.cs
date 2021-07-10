using Common.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockBrokerWallet
    {
        public StockBroker StockBroker { get; set; }
        public double Amount { get; set; }
        public Keyword CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}

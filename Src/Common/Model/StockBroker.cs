using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockBroker : ElasticsearchIndex
    {
        public override string IndexName => "stock_broker";

        [Text(Name = "Name")]
        public string Name { get; set; }

        [Nested(Name = "API")]
        public StockBrokerAPI API { get; set; }

        [Nested(Name = "Wallet")]
        public StockBrokerWallet Wallet { get; set; }
    }
}

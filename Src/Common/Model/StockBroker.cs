using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockBroker
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public StockBrokerAPI API { get; set; }
        public StockBrokerWallet Wallet { get; set; }
    }
}

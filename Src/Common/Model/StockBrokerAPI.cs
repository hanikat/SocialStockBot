using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockBrokerAPI
    {
        public StockBroker StockBroker { get; set; }
        public byte StockBrokerId { get; set; }
        public string Key { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
    }
}

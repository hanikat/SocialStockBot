using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockBrokerAPI
    {
        [Text(Name = "Key")]
        public string Key { get; set; }

        [Text(Name = "Username")]
        public string Username { get; set; }

        [Text(Name = "Password")]
        public string Password { get; set; }

        [Text(Name = "URL")]
        public string URL { get; set; }
    }
}

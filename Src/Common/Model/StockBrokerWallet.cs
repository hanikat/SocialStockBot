using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockBrokerWallet
    {

        [Number(NumberType.Double, Name = "Amount")]
        public double Amount { get; set; }

        [Number(NumberType.Integer, Name = "CurrencyId")]
        public int CurrencyId { get; set; }
    }
}

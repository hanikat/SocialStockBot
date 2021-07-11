using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Stock : ElasticsearchIndex
    {
        public override string IndexName
        {
            get { return "stocks"; }
        }

        [Text(Name = "StockTicker")]
        public string StockTicker { get; set; }

        [Text(Name = "Name")]
        public string Name { get; set; }

        [Number(NumberType.Double, Name = "CompanyValue")]
        public double CompanyValue { get; set; }

        [Number(NumberType.Integer, Name = "CurrencyId")]
        public int CurrencyId { get; set; }
        
    }
}

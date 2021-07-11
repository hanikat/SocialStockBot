using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockPrice : ElasticsearchIndex
    {
        public override string IndexName => "stock_prices";

        [Number(NumberType.Integer, Name = "StockId")]
        public int StockId { get; set; }

        [Number(NumberType.Double, Name = "CurrentPrice")]
        public double CurrentPrice { get; set; }

        [Number(NumberType.Double, Name = "PE")]
        public double PE { get; set; }

        [Number(NumberType.Double, Name = "CompanyValue")]
        public double CompanyValue { get; set; }

    }
}

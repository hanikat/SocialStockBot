using Common.Utility;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockMarket : ElasticsearchIndex
    {
        public override string IndexName => "stock_market";

        [Nested]
        public Utility.TimeOfDay OpensAt { get; set; }

        [Nested]
        public Utility.TimeOfDay CloseAt { get; set; }

        [Object]
        public List<DayOfYear> Holidays { get; set; }

        [Object]
        public TimeZoneInfo TimeZone { get; set; }
    }

    public class StockMarketKey : Key
    {
        public StockMarketKey(int id) : base(id)
        {
        }

        public override string IndexName => "stock_market";

    }


}

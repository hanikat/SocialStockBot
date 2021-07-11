using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace DataRetriever.DataAccessors
{
    public class StockMarketDataAccessor : ElasticsearchDataAccessor<StockMarket>
    {
        public override void CreateIndex()
        {
            CreateIndex(new StockMarket());
        }

        public override void DeleteIndex()
        {
            DeleteIndex(new StockMarket());
        }

        public override bool IndexExists()
        {
            return IndexExists(new StockMarket());
        }
    }
}

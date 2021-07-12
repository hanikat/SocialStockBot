using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace ElasticsearchDataAccess.DataAccessors
{
    public class StockPriceDataAccessor : ElasticsearchDataAccessor<StockPrice>, IElasticsearchIndexDataAccessor
    {
        public override void CreateIndex()
        {
            CreateIndex(new StockPrice());
        }

        public override void DeleteIndex()
        {
            DeleteIndex(new StockPrice());
        }

        public override bool IndexExists()
        {
            return IndexExists(new StockPrice());
        }
    }
}

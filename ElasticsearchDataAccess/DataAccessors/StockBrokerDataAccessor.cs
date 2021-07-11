using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace ElasticsearchDataAccess.DataAccessors
{
    public class StockBrokerDataAccessor : ElasticsearchDataAccessor<StockBroker>
    {
        public override void CreateIndex()
        {
            CreateIndex(new StockBroker());
        }

        public override void DeleteIndex()
        {
            DeleteIndex(new StockBroker());
        }

        public override bool IndexExists()
        {
            return IndexExists(new StockBroker());
        }
    }
}

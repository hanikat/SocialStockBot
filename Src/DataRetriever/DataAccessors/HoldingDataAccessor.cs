using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace DataRetriever.DataAccessors
{
    public class HoldingDataAccessor : ElasticsearchDataAccessor<Holding>
    {
        public override void CreateIndex()
        {
            CreateIndex(new Holding());
        }

        public override void DeleteIndex()
        {
            DeleteIndex(new Holding());
        }

        public override bool IndexExists()
        {
            return IndexExists(new Holding());
        }
    }
}

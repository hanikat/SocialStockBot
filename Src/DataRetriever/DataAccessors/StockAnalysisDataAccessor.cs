using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace DataRetriever.DataAccessors
{
    public class StockAnalysisDataAccessor : ElasticsearchDataAccessor<StockAnalysis>
    {
        public override void CreateIndex()
        {
            CreateIndex(new StockAnalysis());
        }

        public override void DeleteIndex()
        {
            DeleteIndex(new StockAnalysis());
        }

        public override bool IndexExists()
        {
            return IndexExists(new StockAnalysis());
        }
    }
}

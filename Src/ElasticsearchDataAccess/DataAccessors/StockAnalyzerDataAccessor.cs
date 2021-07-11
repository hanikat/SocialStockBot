using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace ElasticsearchDataAccess.DataAccessors
{
    public class StockAnalyzerDataAccessor : ElasticsearchDataAccessor<StockAnalyzer>
    {
        public override void CreateIndex()
        {
            CreateIndex(new StockAnalyzer());
        }

        public override void DeleteIndex()
        {
            DeleteIndex(new StockAnalyzer());
        }

        public override bool IndexExists()
        {
            return IndexExists(new StockAnalyzer());
        }
    }
}

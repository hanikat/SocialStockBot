using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace ElasticsearchDataAccess.DataAccessors
{
    public class CurrencyDataAccessor : ElasticsearchDataAccessor<Currency>, IElasticsearchIndexDataAccessor
    {
        public override void CreateIndex()
        {
            CreateIndex(new Currency());
        }

        public override void DeleteIndex()
        {
            DeleteIndex(new Currency());
        }

        public override bool IndexExists()
        {
            return IndexExists(new Currency());
        }
    }
}

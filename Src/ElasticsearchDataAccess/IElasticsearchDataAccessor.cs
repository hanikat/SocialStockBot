using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchDataAccess
{
    public interface IElasticsearchIndexDataAccessor
    {
        public void CreateIndex();
        public void DeleteIndex();

        public bool IndexExists();
    }
}

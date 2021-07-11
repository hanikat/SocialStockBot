using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockAnalyzer : ElasticsearchIndex
    {
        public override string IndexName => "stock_analyzer";

        [Text(Name = "Name")]
        public string Name { get; set; }

        [Text(Name = "SearchUrl")]
        public string SearchURL { get; set; }

        
    }
}

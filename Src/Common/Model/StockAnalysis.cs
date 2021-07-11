using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockAnalysis : ElasticsearchIndex
    {
        public override string IndexName => "stock_analysis";

        [Number(NumberType.Integer, Name = "AnalyzerId")]
        public int AnalyzerId { get; set; }

        [Number(NumberType.Integer, Name = "StockId")]
        public int StockId { get; set; }

        [Number(NumberType.Byte, Name = "Rating")]
        public byte Rating { get; set; }
        
    }

    public class StockAnalysisKey : Key
    {
        public StockAnalysisKey(int id) : base(id)
        {
        }

        public override string IndexName => "stock_analysis";

    }
}

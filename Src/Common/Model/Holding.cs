using System.Collections.Generic;
using Nest;

namespace Common.Model
{
    public class Holding : ElasticsearchIndex
    {

        [Object]
        public Acquisition Acquisition { get; set; }

        [Object]
        public ExitCondition ExitConditions { get; set; }

        [Number(NumberType.Integer, Name = "StockBrokerId")]
        public int StockBrokerId { get; set; }

        [Number(NumberType.Integer, Name = "StockId")]
        public int StockId { get; set; }

        public override string IndexName
        {
            get { return "holdings"; }
        }
    }
}

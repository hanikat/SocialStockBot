using Nest;
using System;

namespace Common.Model
{
    public class Currency : ElasticsearchIndex
    {
        public override string IndexName => "currencies";

        [Text(Name = "Name")]
        public string Name { get; set; }
        [Number(NumberType.Double, Name = "SekConversionRate")]
        public double SekConversionRate { get; set; }

        

    }
}

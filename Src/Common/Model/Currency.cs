using Nest;
using System;

namespace Common.Model
{
    public class Currency : ElasticsearchIndex
    {
        [Text(Name = "Name")]
        public string Name { get; set; }
        [Number(NumberType.Double, Name = "SekConversionRate")]
        public double SekConversionRate { get; set; }

        public override string IndexName
        {
            get { return "currencies"; }
        }
    }
}

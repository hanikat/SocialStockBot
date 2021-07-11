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

    public class CurrencyKey : Key
    {
        public CurrencyKey(int id) : base(id)
        {
        }

        public override string IndexName => "currencies";

    }
}

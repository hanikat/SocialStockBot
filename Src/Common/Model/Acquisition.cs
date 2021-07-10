using Nest;
using System;

namespace Common.Model
{
    public class Acquisition
    {
        [Number(NumberType.Integer, Name = "Id")]
        public int Id { get; set; }
        [Number(NumberType.Integer, Name = "CurrencyId")]
        public int CurrencyId { get; set; }
        [Number(NumberType.Integer, Name = "ConversionTargetCurrencyId")]
        public int ConversionTargetCurrencyId { get; set; }
        [Date(Format = "date_time")]
        public DateTime Timestamp { get; set; }
        [Number(NumberType.Double, Name = "Fee")]
        public double Fee { get; set; }
        [Number(NumberType.Double, Name = "Price")]
        public double Price { get; set; }
        [Number(NumberType.Integer, Name = "Quantity")]
        public int Quantity { get; set; }
    }
}

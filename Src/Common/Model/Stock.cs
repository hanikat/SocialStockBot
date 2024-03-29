﻿using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Stock : ElasticsearchIndex
    {
        public override string IndexName => "stocks";

        [Text(Name = "StockTicker")]
        public string StockTicker { get; set; }

        [Text(Name = "Name")]
        public string Name { get; set; }

        [Number(NumberType.Integer, Name = "CurrencyId")]
        public int CurrencyId { get; set; }

        [Number(NumberType.Integer, Name = "StockMarketId")]
        public int StockMarketId { get; set; }
        
    }

    public class StockKey : Key
    {
        public StockKey(int id) : base(id)
        {
        }

        public override string IndexName => "stocks";

    }
}

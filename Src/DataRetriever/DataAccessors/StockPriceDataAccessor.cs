﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace DataRetriever.DataAccessors
{
    public class StockPriceDataAccessor : ElasticsearchDataAccessor<StockPrice>
    {
        public override void CreateIndex()
        {
            CreateIndex(new StockPrice());
        }

        public override void DeleteIndex()
        {
            DeleteIndex(new StockPrice());
        }

        public override bool IndexExists()
        {
            return IndexExists(new StockPrice());
        }
    }
}

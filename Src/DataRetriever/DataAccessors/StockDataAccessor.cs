﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace DataRetriever.DataAccessors
{
    public class StockDataAccessor : ElasticsearchDataAccessor<Stock>
    {
        public override void CreateIndex()
        {
            CreateIndex(new Stock());
        }

        public override void DeleteIndex()
        {
            DeleteIndex(new Stock());
        }

        public override bool IndexExists()
        {
            return IndexExists(new Stock());
        }
    }
}
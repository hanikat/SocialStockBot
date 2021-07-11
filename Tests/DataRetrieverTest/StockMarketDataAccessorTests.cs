using Common.Model;
using Common.Utility;
using DataRetriever.DataAccessors;
using DataRetrieverTests;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace DataRetrieverTest
{
    public class StockMarketDataAccessorTests
    {
        [Fact, TestPriority(0)]
        public void RecreateIndex()
        {
            DeleteIndexTest();
            CreateIndexTest();
        }
        private void DeleteIndexTest()
        {
            var dataAccessor = new StockMarketDataAccessor();
            if (dataAccessor.IndexExists())
            {
                dataAccessor.DeleteIndex();
            }

        }
        private void CreateIndexTest()
        {
            var dataAccessor = new StockMarketDataAccessor();
            if (!dataAccessor.IndexExists())
            {
                dataAccessor.CreateIndex();
            }
        }

        [Theory, TestPriority(2)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void AddStockMarketTest(int id)
        {

            var stockMarket = new StockMarket()
            {
                Id = id,
                OpensAt = new TimeOfDay(9,0,0,0),
                CloseAt = new TimeOfDay(17,0,0,0),
                Holidays = new List<DayOfYear>()
                {
                    new DayOfYear(12,31),
                    new DayOfYear(1,1)
                },
                TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")
        };

            new StockMarketDataAccessor().IndexDocument(stockMarket);
        }

    }
}

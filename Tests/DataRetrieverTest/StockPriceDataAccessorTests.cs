using Common.Model;
using DataRetriever.DataAccessors;
using DataRetrieverTests;
using System;
using System.Threading;
using Xunit;

namespace DataRetrieverTest
{
    public class StockPriceDataAccessorTests
    {
        [Fact, TestPriority(0)]
        public void RecreateIndex()
        {
            DeleteIndexTest();
            CreateIndexTest();
        }
        private void DeleteIndexTest()
        {
            var dataAccessor = new StockPriceDataAccessor();
            if (dataAccessor.IndexExists())
            {
                dataAccessor.DeleteIndex();
            }

        }
        private void CreateIndexTest()
        {
            var dataAccessor = new StockPriceDataAccessor();
            if (!dataAccessor.IndexExists())
            {
                dataAccessor.CreateIndex();
            }
        }

        [Theory, TestPriority(2)]
        [InlineData(1, 1, 656.95, 662.03, 632860000000)]
        [InlineData(2, 2, 211.95, 18.35, 432000000000)]
        [InlineData(3, 3, 87.68, 9.58, 57060000000)]

        public void AddStockPriceTest(int id, int stockId, double currentPrice, double pe, double companyValue)
        {
            var stockPrice = new StockPrice()
            {
                Id = id,
                StockId = stockId,
                CurrentPrice = currentPrice,
                PE = pe,
                CompanyValue = companyValue
            };

            new StockPriceDataAccessor().IndexDocument(stockPrice);
        }

    }
}

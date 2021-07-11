using Common.Model;
using DataRetriever.DataAccessors;
using DataRetrieverTests;
using System;
using System.Threading;
using Xunit;

namespace DataRetrieverTest
{
    public class StockDataAccessorTests
    {
        [Fact, TestPriority(0)]
        public void RecreateIndex()
        {
            DeleteIndexTest();
            CreateIndexTest();
        }
        private void DeleteIndexTest()
        {
            var dataAccessor = new StockDataAccessor();
            if (dataAccessor.IndexExists())
            {
                dataAccessor.DeleteIndex();
            }

        }
        private void CreateIndexTest()
        {
            var dataAccessor = new StockDataAccessor();
            if (!dataAccessor.IndexExists())
            {
                dataAccessor.CreateIndex();
            }
        }

        [Theory, TestPriority(2)]
        [InlineData(1, "Tesla, Inc.", 632860000000, "TSLA", 2)]
        [InlineData(2, "Volvo, AB", 432000000000, "VOLV-B.ST", 1)]
        [InlineData(3, "Bayerische Motoren Werke AG", 57060000000, "BMW.DE", 3)]

        public void AddStockTest(int id, string name, double companyValue, string stockTicker, int currencyId)
        {
            var stock = new Stock()
            {
                Id = id,
                Name = name,
                CompanyValue = companyValue,
                StockTicker = stockTicker,
                CurrencyId = currencyId
            };

            new StockDataAccessor().IndexDocument(stock);
        }

    }
}

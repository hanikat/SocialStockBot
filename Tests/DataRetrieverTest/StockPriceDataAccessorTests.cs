using Common.Model;
using ElasticsearchDataAccess.DataAccessors;
using System;
using System.Threading;
using Xunit;

namespace ElasticsearchDataAccessorTests
{
    [Collection("Elasticsearch collection")]
    public class StockPriceDataAccessorTests
    {
        ElasticsearchFixture fixture;

        public StockPriceDataAccessorTests(ElasticsearchFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(1, 1, 656.95, 662.03, 632860000000)]
        [InlineData(2, 2, 211.95, 18.35, 432000000000)]
        [InlineData(3, 3, 87.68, 9.58, 57060000000)]

        public void AddStockPriceTest(int id, int stockId, double currentPrice, double pe, double companyValue)
        {
            var dataAccessor = new StockPriceDataAccessor();

            var item = dataAccessor.ReadDocument(new StockPriceKey(id));

            Assert.Equal(id, item.Id);
            Assert.Equal(stockId, item.StockId);
            Assert.Equal(currentPrice, item.CurrentPrice);
            Assert.Equal(pe, item.PE);
            Assert.Equal(companyValue, item.CompanyValue);
        }

    }
}

using Common.Model;
using ElasticsearchDataAccess.DataAccessors;
using Xunit;

namespace ElasticsearchDataAccessorTests
{
    public class StockDataAccessorTests : IClassFixture<ElasticsearchFixture>
    {
        ElasticsearchFixture fixture;
        public StockDataAccessorTests(ElasticsearchFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(1, "Tesla, Inc.", "TSLA", 2)]
        [InlineData(2, "Volvo, AB", "VOLV-B.ST", 1)]
        [InlineData(3, "Bayerische Motoren Werke AG", "BMW.DE", 3)]

        public void AddStockTest(int id, string name, string stockTicker, int currencyId)
        {
            var dataAccessor = new StockDataAccessor();

            var item = dataAccessor.ReadDocument(new StockKey(id));

            Assert.Equal(id, item.Id);
            Assert.Equal(name, item.Name);
            Assert.Equal(stockTicker, item.StockTicker);
            Assert.Equal(currencyId, item.CurrencyId);
        }

    }
}

using Common.Model;
using ElasticsearchDataAccess.DataAccessors;
using Xunit;

namespace ElasticsearchDataAccessorTests
{
    [Collection("Elasticsearch collection")]
    public class StockBrokerDataAccessorTests
    {
        ElasticsearchFixture fixture;

        public StockBrokerDataAccessorTests(ElasticsearchFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(1, "Alpaca", "Y2xpZW50X2lkOmNsaWVudF9zZWNyZXQ=", "My-User", "My-Password", "https://broker-api.alpaca.markets/v1/", 100000000, 2)]
        [InlineData(2, "Nordnet", "PPxSdewascmNsaWVudF9zZWNyYUJKKQ=", "My-User", "My-Password", "https://www.nordnet.se/api/2", 100000, 1)]

        public void AddStockBrokerTest(int id, string name, string key, string username, string password, string url, double amount, int currencyId)
        {
            var dataAccessor = new StockBrokerDataAccessor();

            var item = dataAccessor.ReadDocument(new StockBrokerKey(id));

            Assert.Equal(id, item.Id);
            Assert.Equal(name, item.Name);
            Assert.Equal(key, item.API.Key);
            Assert.Equal(username, item.API.Username);
            Assert.Equal(password, item.API.Password);
            Assert.Equal(url, item.API.URL);
            Assert.Equal(amount, item.Wallet.Amount);
            Assert.Equal(currencyId, item.Wallet.CurrencyId);
        }

    }
}

using Common.Model;
using DataRetriever.DataAccessors;
using DataRetrieverTests;
using System;
using System.Threading;
using Xunit;

namespace DataRetrieverTest
{
    public class StockBrokerDataAccessorTests
    {
        [Fact, TestPriority(0)]
        public void RecreateIndex()
        {
            DeleteIndexTest();
            CreateIndexTest();
        }
        private void DeleteIndexTest()
        {
            var dataAccessor = new StockBrokerDataAccessor();
            if (dataAccessor.IndexExists())
            {
                dataAccessor.DeleteIndex();
            }

        }
        private void CreateIndexTest()
        {
            var dataAccessor = new StockBrokerDataAccessor();
            if (!dataAccessor.IndexExists())
            {
                dataAccessor.CreateIndex();
            }
        }

        [Theory, TestPriority(2)]
        [InlineData(1, "Alpaca", "Y2xpZW50X2lkOmNsaWVudF9zZWNyZXQ=", "My-User", "My-Password", "https://broker-api.alpaca.markets/v1/", 100000000, 2)]
        [InlineData(2, "Nordnet", "PPxSdewascmNsaWVudF9zZWNyYUJKKQ=", "My-User", "My-Password", "https://www.nordnet.se/api/2", 100000, 1)]

        public void AddStockBrokerTest(int id, string name, string key, string username, string password, string url, double amount, int currencyId)
        {
            StockBroker stockBroker = new StockBroker()
            {
                Id = id,
                Name = name,
                API = new StockBrokerAPI()
                {
                    Key = key,
                    Username = username,
                    Password = password,
                    URL = url
                },
                Wallet = new StockBrokerWallet()
                {
                    Amount = amount,
                    CurrencyId = currencyId
                }
            };

            new StockBrokerDataAccessor().IndexDocument(stockBroker);
        }

    }
}

using Common.Model;
using ElasticsearchDataAccess.DataAccessors;
using System;
using System.Threading;
using Xunit;

namespace ElasticsearchDataAccessorTests
{
    public class HoldingDataAccessorTests : IClassFixture<ElasticsearchFixture>
    {
        ElasticsearchFixture fixture;
        public HoldingDataAccessorTests(ElasticsearchFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory]
        [InlineData(1, 1, 1, 1, 2, 10.0, 100, 20.0, 5.0)]
        [InlineData(2, 2, 2, 2, 1, 50.0, 10, 200.0, 15.0)]
        [InlineData(3, 1, 3, 3, 1, 65.0, 100, 250.0, 45.0)]

        public void ReadHoldingTest(int id, int stockBrokerId, int stockId, int currencyId, int conversionTargetCurrencyId, double price, int quantity, double priceTarget, double stopLoss)
        {
            var dataAccessor = new HoldingDataAccessor();

            var item = dataAccessor.ReadDocument(new HoldingKey(id));

            Assert.Equal(id, item.Id);
            Assert.Equal(stockBrokerId, item.StockBrokerId);
            Assert.Equal(stockId, item.StockId);
            Assert.Equal(currencyId, item.Acquisition.CurrencyId);
            Assert.Equal(conversionTargetCurrencyId, item.Acquisition.ConversionTargetCurrencyId);
            Assert.Equal(price, item.Acquisition.Price);
            Assert.Equal(quantity, item.Acquisition.Quantity);
            Assert.Equal(priceTarget, item.ExitConditions.PriceTarget.Price);
            Assert.Equal(stopLoss, item.ExitConditions.StopLoss.Price);
        }

    }
}

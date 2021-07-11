using Common.Model;
using DataRetriever.DataAccessors;
using DataRetrieverTests;
using System;
using System.Threading;
using Xunit;

namespace DataRetrieverTest
{
    public class HoldingDataAccessorTests
    {
        [Fact, TestPriority(0)]
        public void RecreateIndex()
        {
            DeleteIndexTest();
            CreateIndexTest();
        }
        private void DeleteIndexTest()
        {
            var dataAccessor = new HoldingDataAccessor();
            if (dataAccessor.IndexExists())
            {
                dataAccessor.DeleteIndex();
            }

        }
        private void CreateIndexTest()
        {
            var dataAccessor = new HoldingDataAccessor();
            if (!dataAccessor.IndexExists())
            {
                dataAccessor.CreateIndex();
            }
        }

        [Theory, TestPriority(2)]
        [InlineData(1, 1, 1, 1, 2, 10.0, 100, 20.0, 5.0, 7)]
        [InlineData(2, 2, 2, 2, 1, 50.0, 10, 200.0, 15.0, 6)]
        [InlineData(3, 1, 3, 3, 1, 65.0, 100, 250.0, 45.0, 5)]

        public void AddHoldingTest(int id, int stockBrokerId, int stockId, int currencyId, int conversionTargetCurrencyId, double price, int quantity, double priceTarget, double stopLoss, int exitTime)
        {
            Holding holding = new Holding()
            {
                Id = id,
                StockBrokerId = stockBrokerId,
                StockId = stockId,
                Acquisition = new Acquisition()
                {
                    CurrencyId = currencyId,
                    ConversionTargetCurrencyId = conversionTargetCurrencyId,
                    Fee = 0.0,
                    Price = price,
                    Quantity = quantity,
                    Timestamp = DateTime.Now
                },
                ExitConditions = new ExitCondition()
                {
                    PriceTarget = new PriceTargetExitCondition()
                    {
                        Price = priceTarget
                    },
                    StopLoss = new StopLossExitCondition()
                    {
                        Price = stopLoss
                    },
                    TimeBased = new TimeBasedExitCondition()
                    {
                        ExitTimestamp = DateTime.Now.AddDays(exitTime)
                    }
                }
                
            };

            new HoldingDataAccessor().IndexDocument(holding);
        }

    }
}

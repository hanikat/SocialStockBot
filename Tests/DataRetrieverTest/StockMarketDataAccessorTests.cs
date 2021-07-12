using Common.Model;
using Common.Utility;
using ElasticsearchDataAccess.DataAccessors;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace ElasticsearchDataAccessorTests
{
    [Collection("Elasticsearch collection")]
    public class StockMarketDataAccessorTests
    {
        ElasticsearchFixture fixture;

        public StockMarketDataAccessorTests(ElasticsearchFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void AddStockMarketTest(int id)
        {
            var dataAccessor = new StockMarketDataAccessor();

            var item = dataAccessor.ReadDocument(new StockMarketKey(id));

            Assert.Equal(id, item.Id);
        }

    }

}
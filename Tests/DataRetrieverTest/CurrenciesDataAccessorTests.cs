using Common.Model;
using ElasticsearchDataAccess.DataAccessors;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ElasticsearchDataAccessorTests
{
    [Collection("Elasticsearch collection")]
    public class CurrencyDataAccessorTests 
    {
        ElasticsearchFixture fixture;

        public CurrencyDataAccessorTests(ElasticsearchFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(1, "SEK", 1)]
        [InlineData(2, "USD", 8.58)]
        [InlineData(3, "EUR", 10.19)]
        public void ReadCurrencyTest(int id, string name, double sekConversionRate)
        {
            var dataAccessor = new CurrencyDataAccessor();

            var item = dataAccessor.ReadDocument(new CurrencyKey(id));

            Assert.Equal(id, item.Id);
            Assert.Equal(name, item.Name);
            Assert.Equal(sekConversionRate, item.SekConversionRate);
        }
    }
}

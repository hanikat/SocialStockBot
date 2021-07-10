using Common.Elasticsearch;
using Common.Model;
using DataRetriever.DataAccessors;
using DataRetrieverTests;
using System;
using System.Threading;
using Xunit;

namespace DataRetrieverTest
{
    public class CurrencyDataAccessorTests
    {
        [Fact, TestPriority(0)]
        public void RecreateIndex()
        {
            DeleteIndexTest();
            CreateIndexTest();
        }
        private void DeleteIndexTest()
        {
            var dataAccessor = new CurrencyDataAccessor();
            if (dataAccessor.IndexExists())
            {
                dataAccessor.DeleteIndex();
            }
            
        }
        private void CreateIndexTest()
        {
            var dataAccessor = new CurrencyDataAccessor();
            if (!dataAccessor.IndexExists())
            {
                dataAccessor.CreateIndex();
            }
        }

        [Theory, TestPriority(2)]
        [InlineData(1, "SEK", 1)]
        [InlineData(2, "USD", 8.58)]
        [InlineData(3, "EUR", 10.19)]
        public void AddCurrencyTest(int id, string name, double sekConversionRate)
        {
            Currency currency = new Currency()
            {
                Id = id,
                SekConversionRate = sekConversionRate,
                Name = name,
                UpdatedAt = DateTime.Now
            };

            new CurrencyDataAccessor().IndexDocument(currency);
        }
    }
}

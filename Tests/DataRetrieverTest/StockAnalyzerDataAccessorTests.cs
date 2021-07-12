using Common.Model;
using ElasticsearchDataAccess.DataAccessors;
using System;
using System.Threading;
using Xunit;
namespace ElasticsearchDataAccessorTests
{
    [Collection("Elasticsearch collection")]
    public class StockAnalyzerDataAccessorTests
    {
        ElasticsearchFixture fixture;

        public StockAnalyzerDataAccessorTests(ElasticsearchFixture fixture)
        {
            this.fixture = fixture;
        }
        [Theory]
        [InlineData(1, "BENZINGA", "https://www.benzinga.com/analyst-ratings")]
        [InlineData(2, "TIPRANKS", "https://www.tipranks.com/")]
        public void ReadStockAnalyzerTest(int id, string name, string searchURL)
        {
            var dataAccessor = new StockAnalyzerDataAccessor();

            var item = dataAccessor.ReadDocument(new StockAnalyzerKey(id));

            Assert.Equal(id, item.Id);
            Assert.Equal(name, item.Name);
            Assert.Equal(searchURL, item.SearchURL);
        }
    }

}
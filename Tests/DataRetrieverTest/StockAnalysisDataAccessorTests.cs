using Common.Model;
using ElasticsearchDataAccess.DataAccessors;
using Xunit;

namespace ElasticsearchDataAccessorTests
{
    public class StockAnalysisDataAccessorTests : IClassFixture<ElasticsearchFixture>
    {
        ElasticsearchFixture fixture;
        public StockAnalysisDataAccessorTests(ElasticsearchFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(1, 1, 1, 5)]
        [InlineData(2, 2, 1, 3)]
        [InlineData(3, 3, 2, 2)]

        public void ReadStockPriceTest(int id, int stockId, int analyzerId, byte rating)
        {
            var dataAccessor = new StockAnalysisDataAccessor();

            var item = dataAccessor.ReadDocument(new StockAnalysisKey(id));

            Assert.Equal(id, item.Id);
            Assert.Equal(stockId, item.StockId);
            Assert.Equal(analyzerId, item.AnalyzerId);
            Assert.Equal(rating, item.Rating);
        }

    }
}

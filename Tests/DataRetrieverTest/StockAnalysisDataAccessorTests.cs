using Common.Model;
using DataRetriever.DataAccessors;
using DataRetrieverTests;
using System;
using System.Threading;
using Xunit;

namespace DataRetrieverTest
{
    public class StockAnalysisDataAccessorTests
    {
        [Fact, TestPriority(0)]
        public void RecreateIndex()
        {
            DeleteIndexTest();
            CreateIndexTest();
        }
        private void DeleteIndexTest()
        {
            var dataAccessor = new StockAnalysisDataAccessor();
            if (dataAccessor.IndexExists())
            {
                dataAccessor.DeleteIndex();
            }

        }
        private void CreateIndexTest()
        {
            var dataAccessor = new StockAnalysisDataAccessor();
            if (!dataAccessor.IndexExists())
            {
                dataAccessor.CreateIndex();
            }
        }

        [Theory, TestPriority(2)]
        [InlineData(1, 1, 1, 5)]
        [InlineData(2, 2, 1, 3)]
        [InlineData(3, 3, 2, 2)]

        public void AddStockPriceTest(int id, int stockId, int analyzerId, byte rating)
        {
            StockAnalysis stockAnalysis = new StockAnalysis()
            {
                Id = id,
                StockId = stockId,
                AnalyzerId = analyzerId,
                Rating = rating
            };

            new StockAnalysisDataAccessor().IndexDocument(stockAnalysis);
        }

    }
}

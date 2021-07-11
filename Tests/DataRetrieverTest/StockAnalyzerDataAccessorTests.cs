using Common.Model;
using DataRetriever.DataAccessors;
using DataRetrieverTests;
using System;
using System.Threading;
using Xunit;

namespace DataRetrieverTest
{
    public class StockAnalyzerDataAccessorTests
    {
        [Fact, TestPriority(0)]
        public void RecreateIndex()
        {
            DeleteIndexTest();
            CreateIndexTest();
        }
        private void DeleteIndexTest()
        {
            var dataAccessor = new StockAnalyzerDataAccessor();
            if (dataAccessor.IndexExists())
            {
                dataAccessor.DeleteIndex();
            }
            
        }
        private void CreateIndexTest()
        {
            var dataAccessor = new StockAnalyzerDataAccessor();
            if (!dataAccessor.IndexExists())
            {
                dataAccessor.CreateIndex();
            }
        }

        [Theory, TestPriority(2)]
        [InlineData(1, "BENZINGA", "https://www.benzinga.com/analyst-ratings")]
        [InlineData(2, "TIPRANKS", "https://www.tipranks.com/")]
        public void AddCurrencyTest(int id, string name, string searchURL)
        {
            StockAnalyzer stockAnalyzer = new StockAnalyzer()
            {
                Id = id,
                Name = name,
                SearchURL = searchURL
            };

            new StockAnalyzerDataAccessor().IndexDocument(stockAnalyzer);
        }
    }
}

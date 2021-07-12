using Common.Model;
using Common.Utility;
using ElasticsearchDataAccess;
using ElasticsearchDataAccess.DataAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ElasticsearchDataAccessorTests
{
    public class ElasticsearchFixture : IDisposable
    {

        List<IElasticsearchIndexDataAccessor> dataAccessors = new List<IElasticsearchIndexDataAccessor>()
            {
                new CurrencyDataAccessor(),
                new HoldingDataAccessor(),
                new StockAnalysisDataAccessor(),
                new StockAnalyzerDataAccessor(),
                new StockBrokerDataAccessor(),
                new StockDataAccessor(),
                new StockMarketDataAccessor(),
                new StockPriceDataAccessor()
            };

        public ElasticsearchFixture()
        {
            RecreateIndices();

            AddCurrency(1, "SEK", 1);
            AddCurrency(2, "USD", 8.58);
            AddCurrency(3, "EUR", 10.19);

            AddHolding(1, 1, 1, 1, 2, 10.0, 100, 20.0, 5.0, 7);
            AddHolding(2, 2, 2, 2, 1, 50.0, 10, 200.0, 15.0, 6);
            AddHolding(3, 1, 3, 3, 1, 65.0, 100, 250.0, 45.0, 5);

            AddStockAnalysis(1, 1, 1, 5);
            AddStockAnalysis(2, 2, 1, 3);
            AddStockAnalysis(3, 3, 2, 2);

            AddStockPrice(1, 1, 656.95, 662.03, 632860000000);
            AddStockPrice(2, 2, 211.95, 18.35, 432000000000);
            AddStockPrice(3, 3, 87.68, 9.58, 57060000000);

            AddStockAnalyzer(1, "BENZINGA", "https://www.benzinga.com/analyst-ratings");
            AddStockAnalyzer(2, "TIPRANKS", "https://www.tipranks.com/");

            AddStockBroker(1, "Alpaca", "Y2xpZW50X2lkOmNsaWVudF9zZWNyZXQ=", "My-User", "My-Password", "https://broker-api.alpaca.markets/v1/", 100000000, 2);
            AddStockBroker(2, "Nordnet", "PPxSdewascmNsaWVudF9zZWNyYUJKKQ=", "My-User", "My-Password", "https://www.nordnet.se/api/2", 100000, 1);

            AddStock(1, "Tesla, Inc.", "TSLA", 2);
            AddStock(2, "Volvo, AB", "VOLV-B.ST", 1);
            AddStock(3, "Bayerische Motoren Werke AG", "BMW.DE", 3);

            AddStockMarket(1);
            AddStockMarket(2);
            AddStockMarket(3);

        }

        public void Dispose()
        {
            DeleteIndices();
        }


        private void DeleteIndices()
        {
            foreach(var dataAccessor in dataAccessors)
            {
                dataAccessor.DeleteIndex();
            }
        }
        private void RecreateIndices()
        {

            foreach(var dataAccessor in dataAccessors)
            {
                if (dataAccessor.IndexExists())
                {
                    dataAccessor.DeleteIndex();
                    dataAccessor.CreateIndex();
                }
                else
                {
                    dataAccessor.CreateIndex();
                }
            }
            
        }

        private void AddCurrency(int id, string name, double sekConversionRate)
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

        private void AddHolding(int id, int stockBrokerId, int stockId, int currencyId, int conversionTargetCurrencyId, double price, int quantity, double priceTarget, double stopLoss, int exitTime)
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

        private void AddStockAnalysis(int id, int stockId, int analyzerId, byte rating)
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

        private void AddStockPrice(int id, int stockId, double currentPrice, double pe, double companyValue)
        {
            var stockPrice = new StockPrice()
            {
                Id = id,
                StockId = stockId,
                CurrentPrice = currentPrice,
                PE = pe,
                CompanyValue = companyValue
            };

            new StockPriceDataAccessor().IndexDocument(stockPrice);
        }

        private void AddStockAnalyzer(int id, string name, string searchURL)
        {
            StockAnalyzer stockAnalyzer = new StockAnalyzer()
            {
                Id = id,
                Name = name,
                SearchURL = searchURL
            };

            new StockAnalyzerDataAccessor().IndexDocument(stockAnalyzer);
        }

        private void AddStockBroker(int id, string name, string key, string username, string password, string url, double amount, int currencyId)
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

        private void AddStock(int id, string name, string stockTicker, int currencyId)
        {
            var stock = new Stock()
            {
                Id = id,
                Name = name,
                StockTicker = stockTicker,
                CurrencyId = currencyId
            };

            new StockDataAccessor().IndexDocument(stock);
        }

        private void AddStockMarket(int id)
        {

            var stockMarket = new StockMarket()
            {
                Id = id,
                OpensAt = new TimeOfDay(9, 0, 0, 0),
                CloseAt = new TimeOfDay(17, 0, 0, 0),
                Holidays = new List<DayOfYear>()
                {
                    new DayOfYear(12,31),
                    new DayOfYear(1,1)
                },
                TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")
            };

            new StockMarketDataAccessor().IndexDocument(stockMarket);
        }
    }
}


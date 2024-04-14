using Microsoft.VisualBasic;

namespace CoinTracker.Domain.Tests
{
    [TestClass]
    public class IntegratedSpotOrderTests
    {
        private IntegratedSpotOrder io = new IntegratedSpotOrder();

        [TestInitialize]
        public void Init()
        {
            io = new IntegratedSpotOrder();
        }

        [TestMethod]
        public void 現貨單計算測試_相同價格的單()
        {
            var o1 = new SpotOrder
            {
                Symbol = "BTC/USDT",
                Side = "BUY",
                Price = 70000,
                OrigQty = 1m,
                ExecutedQty = 0.8m
            };

            var o2 = new SpotOrder
            {
                Symbol = "BTC/USDT",
                Side = "BUY",
                Price = 70000,
                OrigQty = 1m,
                ExecutedQty = 0.2m
            };

            io.Set(new SpotOrder[]{ o1, o2 });

            Assert.AreEqual(1m, io.TotalQty);
            Assert.AreEqual(70000m, io.AvgPrice);
            Assert.AreEqual(70000m, io.TotalCost);
        }

        [TestMethod]
        public void 現貨單計算測試_不同價格的單()
        {
            var o1 = new SpotOrder
            {
                
                Symbol = "BTC/USDT",
                Side = "BUY",
                Price = 70000m,
                OrigQty = 1m,
                ExecutedQty = 1m
            };

            var o2 = new SpotOrder
            {
                
                Symbol = "BTC/USDT",
                Side = "BUY",
                Price = 80000m,
                OrigQty = 1m,
                ExecutedQty = 1m
            };

            io.Set(new SpotOrder[]{ o1, o2 });

            Assert.AreEqual(2m, io.TotalQty);
            Assert.AreEqual(150000m, io.TotalCost);
            Assert.AreEqual(75000m, io.AvgPrice);
        }

        [TestMethod]
        public void 現貨單計算測試_不同價格的單2()
        {
            io.Set(new SpotOrder[]
            { 
                new SpotOrder
                {
                    
                    Symbol = "BTC/USDT",
                    Side = "BUY",
                    Price = 100m,
                    OrigQty = 0.5m,
                    ExecutedQty = 0.1m
                },
                new SpotOrder
                {
                    
                    Symbol = "BTC/USDT",
                    Side = "BUY",
                    Price = 100m,
                    OrigQty = 0.5m,
                    ExecutedQty = 0.4m
                }
            });

            Assert.AreEqual(0.5m, io.TotalQty);
            Assert.AreEqual(50m, io.TotalCost);
            Assert.AreEqual(100m, io.AvgPrice);
        }

        [TestMethod]
        public void 現貨單計算測試_不同價格的單3()
        {
            io.Set(new SpotOrder[]
            { 
                new SpotOrder
                {
                    
                    Symbol = "BTC/USDT",
                    Side = "BUY",
                    Price = 100m,
                    OrigQty = 0.5m,
                    ExecutedQty = 0.1m
                },
                new SpotOrder
                {
                    
                    Symbol = "BTC/USDT",
                    Side = "BUY",
                    Price = 100m,
                    OrigQty = 0.5m,
                    ExecutedQty = 0.4m
                },
                new SpotOrder
                {
                    
                    Symbol = "BTC/USDT",
                    Side = "BUY",
                    Price = 200m,
                    OrigQty = 1m,
                    ExecutedQty = 0.4m
                },
                new SpotOrder
                {
                    
                    Symbol = "BTC/USDT",
                    Side = "BUY",
                    Price = 200m,
                    OrigQty = 1m,
                    ExecutedQty = 0.6m
                }
            });

            Assert.AreEqual(1.5m, io.TotalQty);
            Assert.AreEqual(250m, io.TotalCost);
            Assert.AreEqual(167m, io.AvgPrice);
        }
    }
}
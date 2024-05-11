// using Microsoft.VisualBasic;

// namespace CoinTracker.Domain.Tests
// {
//     [TestClass]
//     public class SpotQuarterlyArbStretegyTests
//     {
//         private ISQArbStretygy stretegy;

//         public SpotQuarterlyArbStretegyTests()
//         {
//             stretegy = new SpotQuarterlyArbStretegy();
//         }

//         [TestMethod]
//         public void 測試計算結果()
//         {
//             var spotOrder01 = new SpotOrder()
//             {
//                 Id = 1,
//                 Symbol = "BTC/USDT",
//                 Side = "BUY",
//                 Price = 70000m,
//                 OrigQty = 0.1m,
//                 ExecutedQty = 0.02m
//             };

//             var spotOrder02 = new SpotOrder()
//             {
//                 Id = 2,
//                 Symbol = "BTC/USDT",
//                 Side = "BUY",
//                 Price = 70000m,
//                 OrigQty = 0.1m,
//                 ExecutedQty = 0.08m
//             };
//         }
//     }
// }
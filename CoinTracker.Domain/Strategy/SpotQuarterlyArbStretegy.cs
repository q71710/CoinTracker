// using CoinTracker.Domain;

// namespace CoinTracker
// {
//     public interface ISQArbStretygy
//     {
//         (Exception? exception, SpotQuarterlyArbResult? result) Calc(IntegratedSpotOrder spot, IntegratedSpotOrder future);
//     }

//     public class SpotQuarterlyArbStretegy : ISQArbStretygy
//     {
//         public (Exception? exception, SpotQuarterlyArbResult? result) Calc(IntegratedSpotOrder spot, IntegratedSpotOrder future)
//         {
//             try
//             {
//                 if(future.FutureExpiredDate.HasValue)
//                 {
//                     var result = new SpotQuarterlyArbResult
//                     {
//                         QuarterlyFutureSymbol = future.Symbol,
//                         RemainingDays = future.FutureExpiredDate.Value.AddDays(-DateTime.Now.Day).Day,
//                         Basis = (spot.AvgPrice / future.AvgPrice) - 1
//                     };
//                 }
//             }
//             catch(Exception ex)
//             {
//                 return (ex, null);
//             }

//             return (null, null);
//         }
//     }
// }
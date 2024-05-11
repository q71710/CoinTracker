using System;
using CoinTracker.Domain.Model;

namespace CoinTracker.Domain.Tests.Model
{
	[TestClass]
	public class CoinAmountObjectTests
	{
		[TestMethod]
		public void BTC很少()
		{
			CoinAmountObject co = new CoinAmountObject(Coin.BTC, 0.00145m);
			Assert.AreEqual(0.00145m, co.AmountValue);
			Assert.AreEqual(5, co.RoundValue);
		}

        [TestMethod]
        public void BTC很少_又多兩位數()
        {
            CoinAmountObject co = new CoinAmountObject(Coin.BTC, 0.0014598m);
            Assert.AreEqual(0.00145m, co.AmountValue);
            Assert.AreEqual(5, co.RoundValue);
        }

        [TestMethod]
        public void BTC很大()
        {
            CoinAmountObject co = new CoinAmountObject(Coin.BTC, 123m);
            Assert.AreEqual(123, co.AmountValue);
            Assert.AreEqual(5, co.RoundValue);
        }
    }
}


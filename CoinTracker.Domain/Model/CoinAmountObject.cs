using System;
namespace CoinTracker.Domain.Model
{
    public class CoinAmountObject
    {
        public int RoundValue { get; private set; }

        public decimal AmountValue { get; private set; }

        public CoinAmountObject(Coin coin, decimal value)
        {
            switch (coin)
            {
                case Coin.BTC:
                    RoundValue = 5;
                    var a = (int)Math.Pow(10, RoundValue);
                    value = a * value;

                    //for (int i = 1; i < RoundValue + 1; i++)
                    //{
                    //    value = value * 10;
                    //}

                    value = Math.Floor(value)/a;
                    break;
            }

            AmountValue = value;
        }
    }
}


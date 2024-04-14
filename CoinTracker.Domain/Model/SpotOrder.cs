namespace CoinTracker.Domain
{
    /// <summary>
    /// 訂單類別
    /// </summary>
    public class SpotOrder
    {
        /// <summary>
        /// 訂單建立時間
        /// </summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// 訂單ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// 交易方向
        /// </summary>
        public string Side { get; set; } = string.Empty;

        /// <summary>
        /// 價格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 訂單原始數量
        /// </summary>
        public decimal OrigQty { get; set; }
        
        /// <summary>
        /// 已成交數量
        /// </summary>
        public decimal ExecutedQty { get; set; }

        /// <summary>
        /// 已成交金額
        /// </summary>
        public decimal ExecutedAmount
        {
            get
            {
                return Math.Round(ExecutedQty * Price, 0);
            }
        }
    }
}
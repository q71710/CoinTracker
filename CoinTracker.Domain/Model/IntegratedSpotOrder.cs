namespace CoinTracker.Domain
{
    /// <summary>
    /// 訂單資訊整合類別
    /// </summary>
    public class IntegratedSpotOrder
    {
        /// <summary>
        /// SPOT/FUTURE
        /// </summary>
        public string IntegraedType { get => "SPOT"; }

        /// <summary>
        /// 商品
        /// </summary>
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// 交易方向
        /// </summary>
        public string Side { get; set; } = string.Empty;

        /// <summary>
        /// 平均現貨價格/平均開倉價格
        /// </summary>
        public decimal AvgPrice {get;private set;}

        /// <summary>
        /// 總成本USDT（現貨）
        /// </summary>
        public decimal TotalCost { get; private set; }

        /// <summary>
        /// 總數量
        /// </summary>
        public decimal TotalQty{get;private set;}

        public void Set(IEnumerable<SpotOrder> orders)
        {
            TotalQty = orders.Select(o => o.ExecutedQty).Sum();
            TotalCost = orders.Select(o => o.Price * o.ExecutedQty).Sum();
            AvgPrice = Math.Round(TotalCost / TotalQty, 0);
        }
    }
}
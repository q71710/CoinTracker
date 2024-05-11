namespace CoinTracker
{
    /// <summary>
    /// 現貨季度價差套利計算結果
    /// </summary>
    public class SpotQuarterlyArbResult
    {
        /// <summary>
        /// 季度合約名稱
        /// </summary>
        public string QuarterlyFutureSymbol { get; set; } = string.Empty;

        /// <summary>
        /// 合約剩餘天數
        /// </summary>
        public int RemainingDays { get; set; }

        /// <summary>
        /// 基差
        /// </summary>
        public decimal Basis { get; set; }

        /// <summary>
        /// 總成本
        /// </summary>
        public int TotalCost { get; set; }

        /// <summary>
        /// 推估年化率
        /// </summary>
        public decimal EstimatedAPY 
        { 
            get
            {
                return Basis / RemainingDays * 365;
            }
        }
    }
}
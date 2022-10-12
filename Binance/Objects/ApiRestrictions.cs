namespace Binance.Objects
{
    public class ApiRestrictions
    {
        public bool ipRestrict { get; set; }
        public long createTime { get; set; }
        public bool enableWithdrawals { get; set; }
        public bool enableInternalTransfer { get; set; }
        public bool permitsUniversalTransfer { get; set; }
        public bool enableVanillaOptions { get; set; }
        public bool enableReading { get; set; }
        public bool enableFutures { get; set; }
        public bool enableMargin { get; set; }
        public bool enableSpotAndMarginTrading { get; set; }
        public long tradingAuthorityExpirationTime { get; set; }
    }
}

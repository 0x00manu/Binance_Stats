namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceAsset
    {
        public string? asset {get; set;}
        public double walletBalance {get; set;}     // wallet balance
        public double unrealizedProfit {get; set;}  // unrealized profit
        public double marginBalance {get; set;}     // margin balance
        public double maintMargin {get; set;}       // maintenance margin required
        public double initialMargin {get; set;}     // total initial margin required with current mark price 
        public double positionInitialMargin {get; set;} //initial margin required for positions with current mark price
        public double openOrderInitialMargin {get; set;}// initial margin required for open orders with current mark price
        public double crossWalletBalance {get; set;}// crossed wallet balance
        public double crossUnPnl {get; set;}        // unrealized profit of crossed positions
        public double availableBalance {get; set;}  // available balance
        public double maxWithdrawAmount {get; set;} // maximum amount for transfer out
        public bool marginAvailable {get; set;}     // whether the asset can be used as margin in Multi-Assets mode
        public long updateTime {get; set;}        // last update time 
        public int? autoAssetExchange { get; set; }

    }
}
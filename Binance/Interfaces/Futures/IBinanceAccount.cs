namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceAccount
    {   
        public UInt16 feeTier {get; set;}                   //account commission tier 
        public bool canTrade {get; set;}                    //if can trade
        public bool canDeposit {get; set;}                  //if can transfer in asset
        public bool canWithdraw {get; set;}                 // if can transfer out asset
        public long updateTime {get; set;}                // reserved property, please ignore 
        public double totalInitialMargin {get; set;}        // the sum of USD value of all cross positions/open order initial margin
        public double totalMaintMargin {get; set;}          // the sum of USD value of all cross positions maintenance margin
        public double totalWalletBalance {get; set;}        // total wallet balance in USD
        public double totalUnrealizedProfit {get; set;}     // total unrealized profit in USD
        public double totalMarginBalance {get; set;}        // total margin balance in USD
        public double totalPositionInitialMargin {get; set;}// the sum of USD value of all cross positions initial margin
        public double totalOpenOrderInitialMargin {get; set;}// initial margin required for open orders with current mark price in USD
        public double totalCrossWalletBalance {get; set;}   // crossed wallet balance in USD
        public double totalCrossUnPnl {get; set;}           // unrealized profit of crossed positions in USD
        public double availableBalance {get; set;}          // available balance in USD
        public double maxWithdrawAmount {get; set;}         // maximum virtual amount for transfer out in USD
        public List<Asset>? assets {get; set;}
        public List<Position>? positions {get; set;}
    }
}
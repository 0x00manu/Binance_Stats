namespace Binance.Objects.Futures
{
    /*    {
        "entryPrice": "0.00000",
        "marginType": "isolated", 
        "isAutoAddMargin": "false",
        "isolatedMargin": "0.00000000", 
        "leverage": "10", 
        "liquidationPrice": "0", 
        "markPrice": "6679.50671178",   
        "maxNotionalValue": "20000000", 
        "positionAmt": "0.000",
        "notional": "0",, 
        "isolatedWallet": "0",
        "symbol": "BTCUSDT", 
        "unRealizedProfit": "0.00000000", 
        "positionSide": "BOTH",
        "updateTime": 0
    }*/
    public partial class Asset
    {
        public string? asset {get; set;}
        public double? walletBalance {get; set;}     // wallet balance
        public double? unrealizedProfit {get; set;}  // unrealized profit
        public double? marginBalance {get; set;}     // margin balance
        public double? maintMargin {get; set;}       // maintenance margin required
        public double? initialMargin {get; set;}     // total initial margin required with current mark price 
        public double? positionInitialMargin {get; set;} //initial margin required for positions with current mark price
        public double? openOrderInitialMargin {get; set;}// initial margin required for open orders with current mark price
        public double? crossWalletBalance {get; set;}// crossed wallet balance
        public double? crossUnPnl {get; set;}        // unrealized profit of crossed positions
        public double? availableBalance {get; set;}  // available balance
        public double? maxWithdrawAmount {get; set;} // maximum amount for transfer out
        public bool? marginAvailable {get; set;}     // whether the asset can be used as margin in Multi-Assets mode
        public long? updateTime {get; set;}        // last update time 
    }

    public class Account
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
namespace Binance.Objects.Futures
{
    ///<summary>
    ///positions of all symbols in the market are returned
    /// only "BOTH" positions will be returned with One-way mode
    /// only "LONG" and "SHORT" positions will be returned with Hedge mode
    ///</summary>
    using Binance.Enums.Futures;
    public class Position
    {
        public string? symbol {get; set;}            // symbol name
        public double? initialMargin {get; set;}      // initial margin required with current mark price 
        public double? maintMargin {get; set;}        // maintenance margin required
        public double? unrealizedProfit {get; set;}   // unrealized profit
        public double? positionInitialMargin {get; set;} // initial margin required for positions with current mark price
        public double? openOrderInitialMargin {get; set;} // initial margin required for open orders with current mark price
        public double? leverage {get; set;} // current initial leverage
        public bool? isolated {get; set;} // if the position is isolated
        public double? entryPrice {get; set;} // average entry price
        public double? maxNotional {get; set;} //"// maximum available notional with current leverage
        public double? bidNotional {get; set;} // bids notional, ignore
        public double? askNotional {get; set;} // ask notional, ignore
        public PositionSide? positionSide {get; set;} // position side
        public double? positionAmt {get; set;} // position amount
        public long? updateTime {get; set;} // last update time
        public double? notional {get; set;}
        public double? isolatedWallet {get; set;}

    }
}
/*
    {
        "symbol":"ETHUSDT",
        "initialMargin":"13.80190155",
        "maintMargin":"1.38019015",
        "unrealizedProfit":"-219.31650133",
        "positionInitialMargin":"13.80190155",
        "openOrderInitialMargin":"0",
        "leverage":"20",
        "isolated":false,
        "entryPrice":"3237.611323529",
        "maxNotional":"5000000",
        "positionSide":"LONG",
        "positionAmt":"0.153",
        "notional":"276.03803116",
        "isolatedWallet":"0",
        "updateTime":1658602569788,
        "bidNotional":"0",
        "askNotional":"0"
    },
    {
        "symbol":"ETHUSDT",
        "initialMargin":"0",
        "maintMargin":"0",
        "unrealizedProfit":"0.00000000",
        "positionInitialMargin":"0",
        "openOrderInitialMargin":"0",
        "leverage":"20",
        "isolated":false,
        "entryPrice":"0.0",
        "maxNotional":"5000000",
        "positionSide":"SHORT",
        "positionAmt":"0.000",
        "notional":"0",
        "isolatedWallet":"0",
        "updateTime":0,
        "bidNotional":"0",
        "askNotional":"0"
    },
*/

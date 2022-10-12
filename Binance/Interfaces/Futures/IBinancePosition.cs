namespace Binance.Interfaces.Futures
{
    using Binance.Enums.Futures;
    public interface IBinancePosition
    {
        public string? symbol {get; set;}            // symbol name
        public double initialMargin {get; set;}      // initial margin required with current mark price 
        public double maintMargin {get; set;}        // maintenance margin required
        public double unrealizedProfit {get; set;}   // unrealized profit
        public double positionInitialMargin {get; set;} // initial margin required for positions with current mark price
        public double openOrderInitialMargin {get; set;} // initial margin required for open orders with current mark price
        public double leverage {get; set;} // current initial leverage
        public bool isolated {get; set;} // if the position is isolated
        public double entryPrice {get; set;} // average entry price
        public double maxNotional {get; set;} //"// maximum available notional with current leverage
        public double bidNotional {get; set;} // bids notional, ignore
        public double askNotional {get; set;} // ask notional, ignore
        public PositionSide positionSide {get; set;} // position side
        public double positionAmt {get; set;} // position amount
        public long updateTime {get; set;} // last update time
        public double notional {get; set;}
        public double isolatedWallet {get; set;}

    }
}
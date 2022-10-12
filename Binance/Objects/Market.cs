namespace Binance.Objects
{
    /// <summary>
    /// a part of market status
    /// </summary>
    class Market
    {
        string? baseMarket { get; set; }    //"baseMarket": "btc",    //ticker code of base asset
        string? quoteMarket { get; set; }   //"quoteMarket": "inr",   //ticker code of quote asset
        double minBuyAmount { get; set; }   //"minBuyAmount": 0.001,  //Minimum buy amount of base asset
        double minSellAmount { get; set; }  //"minSellAmount": 0.001, //Minimum sell amount of base asset
        Fee? fee { get; set; }              //"fee": {"bid": {"maker": 0.001,"taker": 0.0025},"ask": {"maker": 0.001,"taker": 0.0025}},
        int basePrecision { get; set; }     //"basePrecision": 4,     //Maximum precision of base asset, this the double point. 
        int quotePrecision { get; set; }    //"quotePrecision": 2,    //Maximum  precision of quote asset
        double low { get; set; }            //"low": "460001.01",     //24 hrs lowest price of base asset
        double high { get; set; }           //"high": "505000.0",     //24 hrs highest price of base asset
        double last { get; set; }           //"last": "480102.0",     //Last traded price in current market
        double open { get; set; }           //"open": 505002,         //Market Open price 24hrs ago
        double volume { get; set; }         //"volume": "0.2071",     //Last 24hrs traded volume
        double sell { get; set; }           //"sell": "490000.0",     //Top ask order price
        double buy { get; set; }            //"buy": "485001.0",      //Top bid order price
        double type { get; set; }           //"type": "SPOT"          //This defines the type of market, currently we have `SPOT` and `P2P`
        double Status { get; set; }         //"Status": "active"      //This defines the current state of the market. This can be `active` or `suspended`
    }

}
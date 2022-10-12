namespace Binance.Interfaces.Futures
{
    using Binance.Enums.Futures;
    using Binance.Enums;
    public interface IBinancePositionRisk
    {
        public double? entryPrice {get; set;}
        public MarginType? marginType {get; set;}
        public bool? isAutoAddMargin {get; set;}
        public double? isolatedMargin {get; set;}
        public Int16? leverage {get; set;}
        public double? liquidationPrice {get; set;}
        public double? markPrice {get; set;}
        public double? maxNotionalValue {get; set;}
        public double? positionAmt {get; set;}
        public double? notional {get; set;}
        public double? isolatedWallet {get; set;}
        public string? symbol {get; set;}
        public double? unRealizedProfit {get; set;}
        public PositionSide? positionSide {get; set;}
        public long? updateTime {get; set;}
    }
}

/*For Hedge position mode
[
    {
        "symbol": "BTCUSDT",
        "positionAmt": "0.001",
        "entryPrice": "22185.2",
        "markPrice": "21123.05052574",
        "unRealizedProfit": "-1.06214947",
        "liquidationPrice": "19731.45529116",
        "leverage": "4",
        "maxNotionalValue": "100000000",
        "marginType": "cross",
        "isolatedMargin": "0.00000000",
        "isAutoAddMargin": "false",
        "positionSide": "LONG",
        "notional": "21.12305052",
        "isolatedWallet": "0",
        "updateTime": 1655217461579
    },
    {
        "symbol": "BTCUSDT",
        "positionAmt": "0.000",
        "entryPrice": "0.0",
        "markPrice": "21123.05052574",
        "unRealizedProfit": "0.00000000",
        "liquidationPrice": "0",
        "leverage": "4",
        "maxNotionalValue": "100000000",
        "marginType": "cross",
        "isolatedMargin": "0.00000000",
        "isAutoAddMargin": "false",
        "positionSide": "SHORT",
        "notional": "0",
        "isolatedWallet": "0",
        "updateTime": 0
    }
]
*/
namespace Binance.Interfaces.Futures
{
    using Binance.Enums.Futures;
    public interface IBinanceUserTrade
    {
        public bool? buyer {get; set;} //": false,
        public double? commission {get; set;} //": "-0.07819010",
        public string? commissionAsset {get; set;} //": "USDT",
        public string? id {get; set;} //": 698759,
        public bool? maker {get; set;} //": false,
        public string? orderId {get; set;} //": 25851813,
        public double? price {get; set;} //": "7819.01",
        public double? qty {get; set;} //": "0.002",
        public double? quoteQty {get; set;} //": "15.63802",
        public double? realizedPnl {get; set;} //": "-0.91539999",
        public OrderSide? side {get; set;} //": "SELL",
        public PositionSide? positionSide {get; set;} //": "SHORT",
        public string? symbol {get; set;} //": "BTCUSDT",
        public long? time {get; set;} //": 1569514978020
    }
}
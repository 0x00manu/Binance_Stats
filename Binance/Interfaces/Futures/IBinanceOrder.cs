namespace Binance.Interfaces.Futures
{
    using Binance.Enums.Futures;
    public interface IBinanceOrder
    {
        public string? clientOrderId { get; set; }
        public double cumQty { get; set; }
        public double cumQuote { get; set; }
        public double executedQty { get; set; }
        public long orderId { get; set; }
        public double avgPrice { get; set; }
        public double origQty { get; set; }
        public double price { get; set; }
        public bool reduceOnly { get; set; }
        public OrderSide side { get; set; }
        public PositionSide positionSide { get; set; }
        public OrderStatus status { get; set; }
        public double stopPrice { get; set; }       // please ignore when order type is TRAILING_STOP_MARKET
        public bool closePosition { get; set; }     // if Close-All
        public string? symbol { get; set; }
        public TimeInForce timeInForce { get; set; }
        public OrderType type { get; set; }
        public OrderType origType { get; set; }
        public double activatePrice { get; set; }   // activation price, only return with TRAILING_STOP_MARKET order
        public double priceRate { get; set; }       // callback rate, only return with TRAILING_STOP_MARKET order
        public long updateTime { get; set; }
        public long time { get; set; }
        public WorkingType? workingType { get; set; }
        public bool priceProtect { get; set; }      // if conditional order trigger is protected
        public int? code { get; set; }   //error handling
        public string? msg { get; set; }//error handling
    }
}

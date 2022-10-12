namespace Binance.Objects.Futures
{
    using Binance.Enums.Futures;
   public class Order
    {
        public string? clientOrderId { get; set; }
        public double? cumQty { get; set; }
        public double? cumQuote { get; set; }
        public double? executedQty { get; set; }
        public long? orderId { get; set; }
        public double? avgPrice { get; set; }
        public double? origQty { get; set; }
        public double? price { get; set; }
        public bool? reduceOnly { get; set; }
        public OrderSide? side { get; set; }
        public PositionSide? positionSide { get; set; }
        public OrderStatus? status { get; set; }
        public double? stopPrice { get; set; }       // please ignore when order type is TRAILING_STOP_MARKET
        public bool? closePosition { get; set; }     // if Close-All
        public string? symbol { get; set; }
        public TimeInForce? timeInForce { get; set; }
        public OrderType? type { get; set; }
        public OrderType? origType { get; set; }
        public double? activatePrice { get; set; }   // activation price, only return with TRAILING_STOP_MARKET order
        public double? priceRate { get; set; }       // callback rate, only return with TRAILING_STOP_MARKET order
        public long? updateTime { get; set; }
        public long? time { get; set; }
        public WorkingType? workingType { get; set; }
        public bool? priceProtect { get; set; }      // if conditional order trigger is protected
        public int? code { get; set; }              //error handling
        public string? msg { get; set; }            //error handling
    }
}
/*
{
    "orderId":71829055708,
    "symbol":"BTCUSDT",
    "status":"NEW",
    "clientOrderId":"hreqpme4eRz4agCdY2ewJg",
    "price":"20500",
    "avgPrice":"0.00000",
    "origQty":"0.001",
    "executedQty":"0",
    "cumQty":"0",
    "cumQuote":"0",
    "timeInForce":"GTC",
    "type":"LIMIT",
    "reduceOnly":false,
    "closePosition":false,
    "side":"SELL",
    "positionSide":"SHORT",
    "stopPrice":"0",
    "workingType":"CONTRACT_PRICE",
    "priceProtect":false,
    "origType":"LIMIT",
    "updateTime":1661663813782
}
var status = client.OrderNew
(
    "BTCUSDT",                      //SYMBOL
    Enums.OrderSide.SELL,           //OPEN
    Enums.PositionSide.SHORT,       //SHORT
    Enums.Futures.OrderType.LIMIT,  //@PRICE not MARK
    Enums.TimeInForce.GTC,          //GOOD TILL CANCEL
    0.001,                          //PRICE
    20500                           //QUANTITY
);
*/
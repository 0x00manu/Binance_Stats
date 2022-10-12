namespace Binance.Objects
{

    public class OrderQueryStatus
    {
        public string? symbol { get; set; }
        public UInt64 orderId { get; set; }
        public int orderListId { get; set; }
        public string? clientOrderId { get; set; }
        public double price { get; set; }
        public double origQty { get; set; }
        public double executedQty { get; set; }
        public double cummulativeQuoteQty { get; set; }
        public Binance.Enums.OrderStatus status { get; set; }
        public Binance.Enums.TimeInForce timeInForce { get; set; }
        public Binance.Enums.OrderType type { get; set; }
        public Binance.Enums.OrderSide side { get; set; }
        public double stopPrice { get; set; }
        public double icebergQty { get; set; }
        public UInt64 time { get; set; }
        public UInt64 updateTime { get; set; }
        public bool isWorking { get; set; }
        public double origQuoteOrderQty { get; set; }
    }
}
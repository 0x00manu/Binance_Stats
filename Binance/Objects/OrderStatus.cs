namespace Binance.Objects
{
    using System;
    public class Fill
    {
        public double price { get; set; }
        public double qty { get; set; }
        public double commission { get; set; }
        public string? commissionAsset { get; set; }
        public UInt64 tradeId { get; set; }
    }

    public class OrderStatus : IEquatable<OrderStatus>

    {
        public string? symbol { get; set; }
        public UInt64 orderId { get; set; }
        public int orderListId { get; set; }
        public string? clientOrderId { get; set; }
        public UInt64 transactTime { get; set; }
        public double price { get; set; }           //Zero for MARKET
        public double origQty { get; set; }
        public double executedQty { get; set; }
        public double cummulativeQuoteQty { get; set; }
        public Binance.Enums.OrderStatus status { get; set; }
        public Binance.Enums.TimeInForce timeInForce { get; set; }
        public Binance.Enums.OrderType type { get; set; }
        public Binance.Enums.OrderSide side { get; set; }
        public List<Fill>? fills { get; set; }

        public bool Equals(OrderStatus obj)
        {
            return 
                this.orderId == obj.orderId &&
                this.symbol == obj.symbol &&
                this.type == obj.type &&
                this.side == obj.side &&
                this.origQty == obj.origQty;
        }

    }
}

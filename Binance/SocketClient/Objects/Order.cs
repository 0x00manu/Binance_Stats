namespace Binance.SocketClient.Objects
{
    public class Order
    {
        public Enums.EVENTTYPE e {get; set;}//  "e": "executionReport",   // Event type
        public UInt64 E  {get; set;}                //"E": 1499405658658,            // Event time
        public string? s {get; set;}                //"s": "ETHBTC",                 // Symbol
        public string? c {get; set;}                //"c": "mUvoqJxFIILMdfAW5iGSOW", // Client order ID
        Binance.Enums.OrderSide S {get; set;}           //"S": "BUY",                    // Side
        Binance.Enums.OrderType o {get; set;}           //"o": "LIMIT",                  // Order type
        Binance.Enums.TimeInForce f {get; set;}         //"f": "GTC",                    // Time in force
        public double q {get; set;}                 //"q": "1.00000000",             // Order quantity
        public double p {get; set;}                 //"p": "0.10264410",             // Order price
        public double P {get; set;}                 //"P": "0.00000000",             // Stop price
        public ushort d {get; set;}                 //"d": 4,                        // Trailing Delta; This is only visible if the order was a trailing stop order.
        public double F {get; set;}                 //"F": "0.00000000",             // Iceberg quantity
        public int g {get; set;}                    //"g": -1,                       // OrderListId
        public string? C {get; set;}                //"C": "",                       // Original client order ID; This is the ID of the order being canceled
        public Binance.Enums.OrderStatus x {get; set;}  //"x": "NEW",                    // Current execution type
        public Binance.Enums.OrderStatus X {get; set;}  //"X": "NEW",                    // Current order status
        public string? r {get; set;}                //"r": "NONE",                   // Order reject reason; will be an error code.
        public long i {get; set;}                   //"i": 4293153,                  // Order ID
        public double l {get; set;}                 //"l": "0.00000000",             // Last executed quantity
        public double z {get; set;}                 //"z": "0.00000000",             // Cumulative filled quantity
        public double L {get; set;}                 //"L": "0.00000000",             // Last executed price
        public double n {get; set;}                 //"n": "0",                      // Commission amount
        public string? N {get; set;}                //"N": null,                     // Commission asset
        public UInt64 T {get; set;}                 //"T": 1499405658657,            // Transaction time
        public int t {get; set;}                    //"t": -1,                       // Trade ID
        public int I {get; set;}                    //"I": 8641984,                  // Ignore
        public bool w {get; set;}                   //"w": true,                     // Is the order on the book?
        public bool m {get; set;}                   //"m": false,                    // Is this trade the maker side?
        public bool M {get; set;}                   //"M": false,                    // Ignore
        public UInt64 O {get; set;}                 //"O": 1499405658657,            // Order creation time
        public double Z {get; set;}                 //"Z": "0.00000000",             // Cumulative quote asset transacted quantity
        public double Y {get; set;}                 //"Y": "0.00000000",             // Last quote asset transacted quantity (i.e. lastPrice * lastQty)
        public double Q {get; set;}                 //"Q": "0.00000000"              // Quote Order Qty
    }
}

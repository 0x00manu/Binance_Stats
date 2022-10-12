namespace Binance.SocketClient.Objects
{
    public class BookTicker
    {

        public int u { get; set; }
        public string? s { get; set; }
        public string? b { get; set; }
        public string? B { get; set; }
        public string? a { get; set; }
        public string? A { get; set; }
    }
}
/*{
  "u":400900217,     // order book updateId
  "s":"BNBUSDT",     // symbol
  "b":"25.35190000", // best bid price
  "B":"31.21000000", // best bid qty
  "a":"25.36520000", // best ask price
  "A":"40.66000000"  // best ask qty
}
*/
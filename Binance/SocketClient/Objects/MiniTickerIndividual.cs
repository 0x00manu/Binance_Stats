namespace Binance.SocketClient.Objects
{
  public class MiniTickerIndividual
  {
      public string? e { get; set; }
      public int E { get; set; }
      public string? s { get; set; }
      public string? p { get; set; }
      public string? P { get; set; }
      public string? w { get; set; }
      public string? x { get; set; }
      public string? c { get; set; }
      public string? Q { get; set; }
      public string? b { get; set; }
      public string? B { get; set; }
      public string? a { get; set; }
      public string? A { get; set; }
      public string? o { get; set; }
      public string? h { get; set; }
      public string? l { get; set; }
      public string? v { get; set; }
      public string? q { get; set; }
      public int O { get; set; }
      public int C { get; set; }
      public int F { get; set; }
      public int L { get; set; }
      public int n { get; set; }
  }
}

/*{
  "e": "24hrTicker",  // Event type
  "E": 123456789,     // Event time
  "s": "BNBBTC",      // Symbol
  "p": "0.0015",      // Price change
  "P": "250.00",      // Price change percent
  "w": "0.0018",      // Weighted average price
  "x": "0.0009",      // First trade(F)-1 price (first trade before the 24hr rolling window)
  "c": "0.0025",      // Last price
  "Q": "10",          // Last quantity
  "b": "0.0024",      // Best bid price
  "B": "10",          // Best bid quantity
  "a": "0.0026",      // Best ask price
  "A": "100",         // Best ask quantity
  "o": "0.0010",      // Open price
  "h": "0.0025",      // High price
  "l": "0.0010",      // Low price
  "v": "10000",       // Total traded base asset volume
  "q": "18",          // Total traded quote asset volume
  "O": 0,             // Statistics open time
  "C": 86400000,      // Statistics close time
  "F": 0,             // First trade ID
  "L": 18150,         // Last trade Id
  "n": 18151          // Total number of trades
}
*/
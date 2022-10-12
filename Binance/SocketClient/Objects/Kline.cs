
namespace Binance.SocketClient.Objects
{
  public class Kline
  {
    public string? e { get; set; }
    public int E { get; set; }
    public string? s { get; set; }
    public K? k { get; set; }
  }
  public class K
  {
    public int t { get; set; }
    public int T { get; set; }
    public string? s { get; set; }
    public string? i { get; set; }
    public int f { get; set; }
    public int L { get; set; }
    public string? o { get; set; }
    public string? c { get; set; }
    public string? h { get; set; }
    public string? l { get; set; }
    public string? v { get; set; }
    public int n { get; set; }
    public bool x { get; set; }
    public string? q { get; set; }
    public string? V { get; set; }
    public string? Q { get; set; }
    public string? B { get; set; }
  }
}
/*{
  "e": "kline",     // Event type
  "E": 123456789,   // Event time
  "s": "BNBBTC",    // Symbol
  "k": {
    "t": 123400000, // Kline start time
    "T": 123460000, // Kline close time
    "s": "BNBBTC",  // Symbol
    "i": "1m",      // Interval
    "f": 100,       // First trade ID
    "L": 200,       // Last trade ID
    "o": "0.0010",  // Open price
    "c": "0.0020",  // Close price
    "h": "0.0025",  // High price
    "l": "0.0015",  // Low price
    "v": "1000",    // Base asset volume
    "n": 100,       // Number of trades
    "x": false,     // Is this kline closed?
    "q": "1.0000",  // Quote asset volume
    "V": "500",     // Taker buy base asset volume
    "Q": "0.500",   // Taker buy quote asset volume
    "B": "123456"   // Ignore
  }
}
*/

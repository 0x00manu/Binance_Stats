    namespace Binance.SocketClient.Objects
    {
        public class MiniTicker24Hr
        {
            public string? e { get; set; }   // Event type
            public UInt64 E { get; set; }   // Event time
            public string? s { get; set; }   // Symbol
            public double c { get; set; }   // Close price
            public double o { get; set; }   // Open price
            public double h { get; set; }   // High price
            public double l { get; set; }   // Low price
            public double v { get; set; }   // Total traded base asset volume
            public double q { get; set; }   // Total traded quote asset volume
        }
    }

/*  {
    "e": "24hrMiniTicker",  // Event type
    "E": 123456789,         // Event time
    "s": "BNBBTC",          // Symbol
    "c": "0.0025",          // Close price
    "o": "0.0010",          // Open price
    "h": "0.0025",          // High price
    "l": "0.0010",          // Low price
    "v": "10000",           // Total traded base asset volume
    "q": "18"               // Total traded quote asset volume
  }*/

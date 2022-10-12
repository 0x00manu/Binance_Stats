namespace Binance.SocketClient.Objects
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class AggTrade
    {
        public string? e { get; set; }
        public long E { get; set; }
        public int a { get; set; }
        public string? s { get; set; }
        public string? p { get; set; }
        public string? q { get; set; }
        public int f { get; set; }
        public int l { get; set; }
        public long T { get; set; }
        public bool m { get; set; }
    }
    /*{
      "e": "aggTrade",  // Event type
      "E": 123456789,   // Event time
      "s": "BNBBTC",    // Symbol
      "a": 12345,       // Aggregate trade ID
      "p": "0.001",     // Price
      "q": "100",       // Quantity
      "f": 100,         // First trade ID
      "l": 105,         // Last trade ID
      "T": 123456785,   // Trade time
      "m": true,        // Is the buyer the market maker?
      "M": true         // Ignore
    }*/
}

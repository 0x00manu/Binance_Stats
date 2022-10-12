namespace Binance.Objects
{
    using System;
    using Interfaces;
    public class OrderBook:IBinanceOrderBook
    {
        public UInt64 lastUpdateId { get; set; }
        public List<List<double>>? bids { get; set; }
        public List<List<double>>? asks { get; set; }
    }
}
/*
{
  "lastUpdateId": 1027024,
  "bids": [
    [
      "4.00000000",     // PRICE
      "431.00000000"    // QTY
    ]
  ],
  "asks": [
    [
      "4.00000200",
      "12.00000000"
    ]
  ]
}
*/
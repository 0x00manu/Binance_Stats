namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceOrderBook
    {
        public long lastUpdateId { get; set; }
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
namespace Binance.SocketClient.Objects
{
    public class BookTickerPartial
    {
        public int lastUpdateId { get; set; }
        public List<List<string>>? bids { get; set; }
        public List<List<string>>? asks { get; set; }
    }
}
//Stream Names: <symbol>@depth<levels> OR <symbol>@depth<levels>@100ms.
//Update Speed: 1000ms or 100ms

/*{
  "lastUpdateId": 160,  // Last update ID
  "bids": [             // Bids to be updated
    [
      "0.0024",         // Price level to be updated
      "10"              // Quantity
    ]
  ],
  "asks": [             // Asks to be updated
    [
      "0.0026",         // Price level to be updated
      "100"             // Quantity
    ]
  ]
}
*/
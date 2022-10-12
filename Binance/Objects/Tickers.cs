namespace Binance.Objects
{
    public class Tickers
    {

        public string? symbol { get; set; }      //[{"symbol":"btcinr",
        public string? baseAsset { get; set; }   //"baseAsset":"btc",
        public string? quoteAsset { get; set; }  //"quoteAsset":"inr",
        public double openPrice { get; set; }  //"openPrice":"5084814.0",
        public double lowPrice { get; set; }   //"lowPrice":"5024000.0",
        public double highPrice { get; set; }  //"highPrice":"5169742.0",
        public double lastPrice { get; set; }  //"lastPrice":"5157000.0",
        public double volume { get; set; }     //"volume":"32.41724",
        public double bidPrice { get; set; }   //"bidPrice":"5155000.0",
        public double askPrice { get; set; }   //"askPrice":"5158997.0",
        public long at { get; set; }            //"at":1636817391000},
    }

}
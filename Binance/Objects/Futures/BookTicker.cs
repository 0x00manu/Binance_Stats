namespace Binance.Futures.Rest.Objects
{
    public class BookTicker
    {
        public string? symbol {get; set;}
        public double bidPrice {get; set;}
        public double bidQty {get; set;}
        public double askPrice {get; set;}
        public double askQty {get; set;}
        public long time {get; set;}
    }
}
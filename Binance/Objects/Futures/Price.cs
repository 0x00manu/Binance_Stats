namespace Binance.Futures.Rest.Objects
{
    public class Price
    {
        public string? symbol {get; set;}
        public double price {get; set;}
        public long time {get; set;}
    }
}
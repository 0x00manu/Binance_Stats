namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinancePrice
    {
        public string? symbol {get; set;}
        public double price {get; set;}
        public long time {get; set;}
    }
}
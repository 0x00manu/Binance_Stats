namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceOpenInterest    
    {
        public double openInterest {get; set;}
        public string? symbol {get; set;}
        public long time {get; set;}
    }
}
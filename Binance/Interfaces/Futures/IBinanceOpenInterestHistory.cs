namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceOpenInterestHistory
    {
        public string? symbol {get; set;}
        public double sumOpenInterest {get; set;}
        public double sumOpenInterestValue {get; set;}
        public long timestamp {get; set;}
    }
}
namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceFundingRate
    {
        public string? symbol{get; set;}
        public double fundingRate{get; set;}
        public long fundingTime{get; set;}
    }
}
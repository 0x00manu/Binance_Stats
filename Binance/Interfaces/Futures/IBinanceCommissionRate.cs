namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceCommissionRate
    {
        public string? symbol {get; set;}
        public double makerCommissionRate {get; set;}
        public double takerCommissionRate {get; set;}
    }
}
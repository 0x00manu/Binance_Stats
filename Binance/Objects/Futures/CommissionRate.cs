namespace Binance.Objects.Futures
{
    public class CommissionRate
    {
        public string? symbol {get; set;}
        public double makerCommissionRate {get; set;}
        public double takerCommissionRate {get; set;}
    }
}
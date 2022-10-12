namespace Binance.Objects.Futures
{
    public class FundingRate
    {
        public string? symbol{get; set;}
        public double fundingRate{get; set;}
        public long fundingTime{get; set;}
    }
}
namespace Binance.Futures.Rest.Objects
{
    public class PremimumIndex
    {
        public string? symbol {get; set;}
        public double markPrice {get; set;}
        public double indexPrice {get; set;}
        public double estimatedSettlePrice {get; set;}  //"11781.16138815", // Estimated Settle Price, only useful in the last hour before the settlement starts.
        public double lastFundingRate {get; set;}
        public long nextFundingTime {get; set;}
        public double interestRate {get; set;}
        public long time {get; set;}
    }
}
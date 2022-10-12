namespace Binance.Objects.Futures
{
    public class openInterestHist
    {
        public string? symbol {get; set;}
        public double sumOpenInterest {get; set;}
        public double sumOpenInterestValue {get; set;}
        public long timestamp {get; set;}
    }
}
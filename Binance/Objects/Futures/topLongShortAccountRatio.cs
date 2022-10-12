namespace Binance.Objects.Futures
{
    public class topLongShortAccountRatio
    { 
        public string? symbol {get; set;}
        public double longShortRatio {get; set;}
        public double longAccount {get; set;}
        public double shortAccount {get; set;}
        public long timestamp {get; set;}

     }
}
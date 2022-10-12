namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceTopLongShortPositionRatio
    { 
        public string? symbol {get; set;}
        public double longShortRatio {get; set;}
        public double longAccount {get; set;}
        public double shortAccount {get; set;}
        public long timestamp {get; set;}

     }
}
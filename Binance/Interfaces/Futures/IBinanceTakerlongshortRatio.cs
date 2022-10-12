namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceTakerlongshortRatio
    { 
        public double buySellRatio {get; set;}
        public double buyVol {get; set;}
        public double sellVol {get; set;}
        public long timestamp {get; set;}

     }
}
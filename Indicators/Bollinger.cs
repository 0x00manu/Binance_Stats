namespace BB
{
    using Skender.Stock.Indicators;

    public class Bollinger
    {
        public Binance.Objects.Kline kline {get; set;}
        public BollingerBandsResult Band {get; set;}
    }
}
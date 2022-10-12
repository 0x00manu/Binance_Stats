namespace Binance.Objects
{
    public class Kline
    {
        public long OpenTime {get; set;}
        public double? OpenPrice {get; set;}
        public double? HighPrice {get; set;}
        public double? LowPrice {get; set;}
        public double? ClosePrice {get; set;}
        public double? Volume {get; set;}
        public double? CloseTime {get; set;}
        public double? QuoteAssetVolume {get; set;}
        public double? NumberOfTrades {get; set;}
        public double? TakerBasevolume {get; set;}
        public double? TakerQuoteVolume {get; set;}
        public string? Ignore {get; set;}
    }
}

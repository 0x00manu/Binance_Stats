namespace Binance.Objects
{
    public partial class Ticks
    {
        public string? Symbol { get; set; }
        public string? BaseAsset { get; set; }
        public string? QuoteAsset { get; set; }
        public double OpenPrice { get; set; }
        public double LowPrice { get; set; }
        public double HighPrice { get; set; }
        public double LastPrice { get; set; }
        public double Volume { get; set; }
        public double BidPrice { get; set; }
        public double AskPrice { get; set; }
        public string? At { get; set; }
    }

}

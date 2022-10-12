namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceTicker24hr
    {
        public string? symbol {get; set;}
        public double priceChange {get; set;}
        public double priceChangePercent {get; set;}
        public double weightedAvgPrice {get; set;}
        public double lastPrice {get; set;}
        public double lastQty {get; set;}
        public double openPrice {get; set;}
        public double highPrice {get; set;}
        public double lowPrice {get; set;}
        public double volume {get; set;}
        public double quoteVolume {get; set;}
        public long openTime {get; set;}
        public long closeTime {get; set;}
        public UInt32 firstId {get; set;}
        public UInt32 lastId {get; set;}
        public UInt32 count {get; set;}
    }
}
﻿namespace Binance.Objects
{
    public class Symbol
    {
        public string? symbol { get; set; }
        public string? status { get; set; }
        public string? baseAsset { get; set; }
        public int baseAssetPrecision { get; set; }
        public string? quoteAsset { get; set; }
        public int quotePrecision { get; set; }
        public int quoteAssetPrecision { get; set; }
        public int baseCommissionPrecision { get; set; }
        public int quoteCommissionPrecision { get; set; }
        public List<string>? orderTypes { get; set; }
        public bool icebergAllowed { get; set; }
        public bool ocoAllowed { get; set; }
        public bool quoteOrderQtyMarketAllowed { get; set; }
        public bool allowTrailingStop { get; set; }
        public bool isSpotTradingAllowed { get; set; }
        public bool isMarginTradingAllowed { get; set; }
        public List<Filters>? filters { get; set; }
        public List<string>? permissions { get; set; }
    }
}
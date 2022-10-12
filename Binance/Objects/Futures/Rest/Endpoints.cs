namespace Binance.Objects.Futures.Rest
{
    public static partial class Endpoints
    {
        public const string burl =  @"https://fapi.binance.com";
        public const string exchangeInfo = burl + @"/fapi/v1/exchangeInfo";
        public const string historicalTrades = burl + @"/fapi/v1/historicalTrades";
        public const string aggTrades = burl + @"/fapi/v1/aggTrades";
        public const string klines = burl + @"/fapi/v1/klines";
        public const string continuousKlines = burl + @"/fapi/v1/continuousKlines";
        public const string indexPriceKlines = burl + @"/fapi/v1/indexPriceKlines";
        public const string markPriceKlines = burl + @"/fapi/v1/markPriceKlines";
        public const string premiumIndex = burl + @"/fapi/v1/premiumIndex";
        public const string ticker24hr = burl + @"/fapi/v1/ticker/24hr";
        public const string price = burl + @"/fapi/v1/ticker/price";
        public const string bookTicker = burl + @"/fapi/v1/ticker/bookTicker";
        public const string openInterest = burl + @"/fapi/v1/openInterest";
        public const string lvtKlines = burl + @"/fapi/v1/lvtKlines";
        public const string indexInfo = burl + @"/fapi/v1/indexInfo";
        public const string assetIndex = burl + @"/fapi/v1/assetIndex";        
        ///<symmary>
        ///Does not take Signature
        ///</summary>

    }
}
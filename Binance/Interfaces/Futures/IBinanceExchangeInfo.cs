namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceFilter
    {
        public double minPrice { get; set; }
        public double maxPrice { get; set; }
        public Enums.FilterType? filterType { get; set; }
        public double tickSize { get; set; }
        public double stepSize { get; set; }
        public double maxQty { get; set; }
        public double minQty { get; set; }
        public int? limit { get; set; }
        public double notional { get; set; }
        public string? multiplierDown { get; set; }
        public string? multiplierUp { get; set; }
        public string? multiplierDecimal { get; set; }
    }

    public interface IBinanceRateLimit
    {
        public string? rateLimitType { get; set; }
        public string? interval { get; set; }
        public int intervalNum { get; set; }
        public int limit { get; set; }
    }

    public interface IBinanceExchangeInfo
    {
        public string? timezone { get; set; }
        public long serverTime { get; set; }
        public string? futuresType { get; set; }
        public List<RateLimit>? rateLimits { get; set; }
        public List<object>? exchangeFilters { get; set; }
        public List<Asset>? assets { get; set; }
        public List<Symbol>? symbols { get; set; }
    }

    public interface IBinanceSymbol
    {
        public string? symbol { get; set; }
        public string? pair { get; set; }
        public Enums.ContractType contractType { get; set; }
        public long deliveryDate { get; set; }
        public long onboardDate { get; set; }
        public string? status { get; set; }
        public double maintMarginPercent { get; set; }
        public double requiredMarginPercent { get; set; }
        public string? baseAsset { get; set; }
        public string? quoteAsset { get; set; }
        public string? marginAsset { get; set; }
        public byte pricePrecision { get; set; }
        public byte quantityPrecision { get; set; }
        public byte baseAssetPrecision { get; set; }
        public byte quotePrecision { get; set; }
        public string? underlyingType { get; set; }
        public List<string>? underlyingSubType { get; set; }
        public int settlePlan { get; set; }
        public double triggerProtect { get; set; }
        public double liquidationFee { get; set; }
        public double marketTakeBound { get; set; }
        public List<Filter>? filters { get; set; }
        public List<Enums.Futures.OrderType>? orderTypes { get; set; }
        public List<Enums.TimeInForce>? timeInForce { get; set; }
    }


}
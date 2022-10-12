namespace Binance.Objects
{
    public class RateLimit
    {
        public string? rateLimitType { get; set; }
        public string? interval { get; set; }
        public int intervalNum { get; set; }
        public int limit { get; set; }
    }

    public class ExchangeInfo
    {
        public string? timezone { get; set; }
        public long serverTime { get; set; }
        public List<RateLimit>? rateLimits { get; set; }
        public List<object>? exchangeFilters { get; set; }
        public List<Symbol>? symbols { get; set; }
    }
}
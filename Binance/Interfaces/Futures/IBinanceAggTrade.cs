namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceAggTrade
    {
        public string? e { get; set; }
        public int E { get; set; }
        public string? s { get; set; }
        public int a { get; set; }
        public string? p { get; set; }
        public string? q { get; set; }
        public int f { get; set; }
        public int l { get; set; }
        public int T { get; set; }
        public bool m { get; set; }
    }
}
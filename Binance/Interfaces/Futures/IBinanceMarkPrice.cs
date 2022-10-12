namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceMarkPrice
    {
        public string? e { get; set; }
        public long E { get; set; }
        public string? s { get; set; }
        public string? p { get; set; }
        public string? i { get; set; }
        public string? P { get; set; }
        public string? r { get; set; }
        public long T { get; set; }
    }
}
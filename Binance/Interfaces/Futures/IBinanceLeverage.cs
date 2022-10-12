namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceLeverage
    {
        public int leverage {get; set;} //": 21,
        public double maxNotionalValue {get; set;} //`": "1000000",
        public string? symbol {get; set;} //`": "BTCUSDT"
    }
}
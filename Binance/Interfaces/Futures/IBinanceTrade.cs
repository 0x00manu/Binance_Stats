namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceTrade
    {
        public string? e {get; set;}//"markPriceUpdate",     // Event type
        public long E {get; set;}// 1562305380000,         // Event time
        public string? s {get; set;}// "BTCUSDT",             // Symbol
        public double p {get; set;}// "11794.15000000",      // Mark price
        public double i {get; set;}// "11784.62659091",      // Index price
        public double P {get; set;}// "11784.25641265",      // Estimated Settle Price, only useful in the last hour before the settlement starts
        public double r {get; set;}// "0.00038167",          // Funding rate
        public long T {get; set;}// 1562306400000          // Next funding time
    }
}

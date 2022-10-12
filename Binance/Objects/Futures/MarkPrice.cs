namespace Binance.Objects.Futures
{
    public class MarkPrice    
    {
        public string? e { get; set; }
        public long E { get; set; }
        public string? s { get; set; }
        public double? p { get; set; }
        public double? i { get; set; }
        public double? P { get; set; }
        public double? r { get; set; }
        public long T { get; set; }
    }
}
//{
//  "e": "markPriceUpdate",     // Event type
//  "E": 1562305380000,         // Event time
//  "s": "BTCUSDT",             // Symbol
//  "p": "11794.15000000",      // Mark price
//  "i": "11784.62659091",      // Index price
//  "P": "11784.25641265",      // Estimated Settle Price, only useful in the last hour before the settlement starts
//  "r": "0.00038167",          // Funding rate
//  "T": 1562306400000          // Next funding time
//}
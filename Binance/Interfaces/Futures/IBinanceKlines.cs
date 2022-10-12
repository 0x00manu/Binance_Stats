namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceKline
    {
        public string? e {get; set;}    //"kline",     // Event type
        public long E {get; set;}       //1638747660000,   // Event time
        public double s {get; set;}     //"BTCUSDT",    // Symbol
        public k? K      {get; set;}    //
    }
    public interface k
    {
        public long t {get; set;}//1638747660000, // Kline start time
        public long T {get; set;}//1638747719999, // Kline close time
        public string? s {get; set;}//"BTCUSDT",  // Symbol
        public string? i {get; set;}//"1m",      // Interval
        public int f {get; set;}//100,       // First trade ID
        public int L {get; set;}//200,       // Last trade ID
        public double o {get; set;}//"0.0010",  // Open price
        public double c {get; set;}//"0.0020",  // Close price
        public double h {get; set;}//"0.0025",  // High price
        public double l {get; set;}//"0.0015",  // Low price
        public double v {get; set;}//"1000",    // Base asset volume
        public int n {get; set;}//100,       // Number of trades
        public bool x {get; set;}//false,     // Is this kline closed?
        public double q {get; set;}//"1.0000",  // Quote asset volume
        public double V {get; set;}//"500",     // Taker buy base asset volume
        public double Q {get; set;}//"0.500",   // Taker buy quote asset volume
        public string? B {get; set;}//"123456"   // Ignore
    }
}

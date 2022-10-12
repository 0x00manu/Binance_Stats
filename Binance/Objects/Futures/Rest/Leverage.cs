namespace Binance.Objects.Futures
{
    ///<summary>
    ///OK Tested
    ///</summary>
    public class Leverage
    {
        public string? symbol {get; set;} //`": "BTCUSDT"
        public int leverage {get; set;} //": 21,
        public double maxNotionalValue {get; set;} //`": "1000000",
    }
}
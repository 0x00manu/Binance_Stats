namespace Binance.Objects
{
    public class TradeFee
    {
        public string? symbol { get; set; }
        public double makerCommission { get; set; }
        public double takerCommission { get; set; }
    }
}
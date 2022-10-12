namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceIncome
    {
        public string? symbol {get; set;}   // trade symbol, if existing
        public Binance.Enums.Futures.IncomeType incomeType {get; set;}
        public double income {get; set;}    // income amount
        public string? asset {get; set;}    // income asset
        public string? info {get; set;}     // extra information
        public long time {get; set;}
        public string? tranId {get; set;}
        public string? tradeId {get; set;}
    }
}
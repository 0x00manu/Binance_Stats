namespace Binance.Objects.Futures
{
    public class Balance
    {
        public string? accountAlias {get; set;}//: "SgsR",    // unique account code
        public string? asset {get; set;}//: "USDT",    // asset name
        public double balance {get; set;}//: "122607.35137903", // wallet balance
        public double crossWalletBalance {get; set;}//: "23.72469206", // crossed wallet balance
        public double crossUnPnl {get; set;}//: "0.00000000"  // unrealized profit of crossed positions
        public double availableBalance {get; set;}//: "23.72469206",       // available balance
        public double maxWithdrawAmount {get; set;}//: "23.72469206",     // maximum amount for transfer out
        public bool marginAvailable {get; set;}//: true,    // whether the asset can be used as margin in Multi-Assets mode
        public long updateTime {get; set;}//: 1617939110373
    }
}
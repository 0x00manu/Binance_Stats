namespace Binance.Objects.Futures.Rest
{
  public class PremiumIndex
  {
    public string? symbol {get; set;}
    public double? markPrice {get; set;}
    public double? indexPrice {get; set;}
    public double? estimatedSettlePrice {get; set;}
    public double? lastFundingRate {get; set;}
    public long? nextFundingTime {get; set;}
    public double? interestRate {get; set;}
    public long? time {get; set;}
  }
}

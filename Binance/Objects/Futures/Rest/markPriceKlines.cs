namespace Binance.Objects.Futures.Rest
{
  public class markPriceKlines
  {
    public long? OpenTime {get; set;} //[0]
    public double? Open {get; set;}   //[1]
    public double? Close {get; set;}  //[2]
    public double? High {get; set;}   //[3]
    public double? Low {get; set;}    //[4]
    public long? CloseTime {get; set;}//[6]
  }
}
        /*
[
  [
    1591256460000,          // Open time
    "9653.29201333",        // Open
    "9654.56401333",        // High
    "9653.07367333",        // Low
    "9653.07367333",        // Close (or latest price)
    "0  ",                  // Ignore
    1591256519999,          // Close time
    "0",                    // Ignore
    60,                     // Ignore
    "0",                    // Ignore
    "0",                    // Ignore
    "0"                     // Ignore
  ]
]
*/

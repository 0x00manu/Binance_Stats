namespace Binance.Objects
{
    /// <summary>
    /// array of funds in my account
    /// </summary>
    public class Funds
    {
        public string? asset { get; set; }       //[{"asset":"inr",
        public double free { get; set; }       //"free":"4999.850315214",
        public double locked { get; set; }     //order placed
        public double reservedFee { get; set; }//"locked":"0.0"}
    }

}
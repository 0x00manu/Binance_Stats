namespace Binance.Objects.Futures
{
    //Isolated Position Margin
    public class PositionMargin
    {
        public double amount {get; set;}//100.0
        public int code {get; set;}     //200
        public string? msg {get; set;}  //"Successfully modify position margin."
        public byte type {get; set;}    //1-> add position margin
    }                                   //2-> reduce position margin
}
namespace Binance.Objects.Futures.Rest
{
    public class indexPriceKlines
    {
        public DateTime? OpenTime {get; set;}   //[0]
        public double? Open {get; set;}         //[1]
        public double? High {get; set;}         //[2]
        public double? Low {get; set;}          //[3]
        public double? Close {get; set;}        //[4]
        //public string? Ignore {get; set;}     //[x]
        public DateTime? CloseTime {get; set;}  //[6]
        //public double? Ignore {get; set;}
        //public double? Ignore {get; set;}
        //public double? Ignore {get; set;}
        //public double? Ignore {get; set;}
        //public double? Ignore {get; set;}
    }
}
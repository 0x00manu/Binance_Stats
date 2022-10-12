namespace Binance.Objects.Futures
{
    public class DualSidePosition
    {
        public int? code {get; set;}                //POST  //": 200,
        public string? msg {get; set;}              //POST  //": "success"
        public bool? dualSidePosition {get; set;}   //GET   // "true": Hedge Mode; "false": One-way Mode
    }    
}


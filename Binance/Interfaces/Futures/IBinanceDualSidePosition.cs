namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceDualSidePosition
    {
        public int? code {get; set;}                //POST  //": 200,
        public string? msg {get; set;}              //POST  //": "success"
        public bool? dualSidePosition {get; set;}   //GET   // "true": Hedge Mode; "false": One-way Mode
    }    
}


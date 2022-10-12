namespace Binance.Objects.Futures
{
    ///<summary>
    ///Order
    ///</summary>
    public class O
    {
        public string? s { get; set; }                  // Symbol
        public Binance.Enums.OrderSide S { get; set; }  // Side BUY->short lost the bet
        public Binance.Enums.OrderType o { get; set; }  // Order Type
        public Binance.Enums.TimeInForce f { get; set; }// Time in Force
        public double q { get; set; }                   // Original Quantity
        public double p { get; set; }                   // Price
        public double ap { get; set;}                   // Average Price <trade price>
        public Binance.Enums.OrderStatus X { get; set; }// Order Status
        public double l { get; set; }                   // Order Last Filled Quantity
        public double z { get; set; }                   // Order Filled Accumulated Quantity
        public long T { get; set; }                     // Order Trade Time
    }
    public class forceOrder
    {
        public string? e { get; set; }  // Event Type
        public long E { get; set; }     // Event Time
        public O? o { get; set; }       // order
    }
/*
        
        
        
        
        
        
        
        
        
        
        

    }

}
*/
}


namespace Binance.Enums
{
    /// <summary>
    /// Represents a single order status.
    /// </summary>
    public enum OrderStatus
    {
        NEW,// 	The order has been accepted by the engine.
        PARTIALLY_FILLED,// 	A part of the order has been filled.
        FILLED,// 	The order has been completed.
        CANCELED,// 	The order has been canceled by the user.
        PENDING_CANCEL,// 	Currently unused
        REJECTED,// 	The order was not accepted by the engine and not processed.
        EXPIRED,// 	The order was canceled according to the order type's rules (e.g. LIMIT FOK orders with no fill, LIMIT IOC or MARKET orders that partially fill)
        //or by the exchange, (e.g. orders canceled during liquidation, orders canceled during maintenance)    
    }

    public enum OCOStatus
    {
        RESPONSE,       //This is used when the ListStatus is responding to a failed action. (E.g. Orderlist placement or cancellation)
        EXEC_STARTED,   //The order list has been placed or there is an update to the order list status.
        ALL_DONE,       //The order list has finished executing and thus no longer active.
    }
    public enum OCOOrderStatus
    {
        EXECUTING,  //Either an order list has been placed or there is an update to the status of the list.
        ALL_DONE, 	//An order list has completed execution and thus no longer active.
        REJECT, 	    //The List Status is responding to a failed action either during order placement or order canceled
    }
}

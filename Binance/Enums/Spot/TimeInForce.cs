namespace Binance.Enums
{
    /// <summary>
    /// The time the order will be active for
    /// </summary>
    public enum TimeInForce
    {
        /// GoodTillCancel orders will stay active until they are filled or canceled
        GTC, //GoodTillCancel, 
        /// ImmediateOrCancel orders have to be at least partially filled upon placing or will be automatically canceled
        IOC,//ImmediateOrCancel
        /// GoodTillCrossing orders will post only
        FOK,//FillOrKill
        /// Good til the order expires or is canceled
        GTX,//GoodTillCrossing
        GTE_GTC//GoodTillExpiredOrCanceled NOT for Futures
    }

}

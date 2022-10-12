namespace Binance.Enums
{
    /// <summary>
    /// The type of an order
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// Limit orders will be placed at a specific price. If the price isn't available in the order book for that asset the order will be added in the order book for someone to fill.
        /// </summary>
        LIMIT,  //MANDATORY: timeInForce, quantity, price
        /// <summary>
        /// Market order will be placed without a price. The order will be executed at the best price available at that time in the order book.
        /// </summary>
        MARKET,  //MANDATORY: quantity or quoteOrderQty
        /// <summary>
        /// Stop loss order. Will execute a market order when the price drops below a price to sell and therefor limit the loss
        /// </summary>
        STOPLOSS,  //MANDATORY: quantity, stopPrice or trailingDelta
        /// <summary>
        /// Stop loss order. Will execute a limit order when the price drops below a price to sell and therefor limit the loss
        /// </summary>
        STOPLOSSLIMIT,  //MANDATORY: timeInForce, quantity, price, stopPrice or trailingDelta
        /// <summary>
        /// Stop loss order. Will execute a market order when the price drops below a price to sell and therefor limit the loss
        /// </summary>
        STOP,  //MANDATORY: 
        /// <summary>
        /// Stop loss order. Will be executed at the best price available at that time in the order book
        /// </summary>
        STOPMARKET,  //MANDATORY: 
        /// <summary>
        /// Take profit order. Will execute a market order when the price rises above a price to sell and therefor take a profit
        /// </summary>
        TAKEPROFIT,  //MANDATORY: quantity, stopPrice or trailingDelta
        /// <summary>
        /// Take profit order. Will be executed at the best price available at that time in the order book
        /// </summary>
        TAKEPROFITMARKET,  //MANDATORY: 
        /// <summary>
        /// Take profit order. Will execute a limit order when the price rises above a price to sell and therefor take a profit
        /// </summary>
        TAKEPROFITLIMIT,  //MANDATORY: timeInForce, quantity, price, stopPrice or trailingDelta
        /// <summary>
        /// Same as a limit order, however it will fail if the order would immediately match, therefor preventing taker orders
        /// </summary>
        LIMITMAKER,  //MANDATORY: quantity, price
        /// <summary>
        /// Trailing stop order will be placed without a price. The order will be executed at the best price available at that time in the order book.
        /// </summary>
        TRAILINGSTOPMARKET,  //MANDATORY: 
        /// <summary>
        /// 
        /// </summary>
        LIQUIDATION  //MANDATORY: 
    }
}
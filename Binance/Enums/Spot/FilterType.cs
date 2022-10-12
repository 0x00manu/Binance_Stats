namespace Binance.Enums
{
    public enum FilterType
    {
        PRICE_FILTER,           //FUTURES & SPOT
        //price >= minPrice
        //price <= maxPrice
        //(price-minPrice) % tickSize == 0
        LOT_SIZE,               //SPOT
        MIN_NOTIONAL,
        //price * quantity. Since MARKET orders have no price, the mark price is used.
        MAX_NUM_ORDERS,
        // the maximum number of orders an account is allowed to have open on a symbol.
        MAX_ALGO_ORDERS,
        EXCHANGE_MAX_NUM_ORDERS,
        EXCHANGE_MAX_ALGO_ORDERS,
        PERCENT_PRICE,
        //BUY: price <= markPrice * multiplierUp
        //SELL: price >= markPrice * multiplierDown
        ICEBERG_PARTS,
        MARKET_LOT_SIZE,
        //quantity >= minQty
        //quantity <= maxQty
        //(quantity-minQty) % stepSize == 0
        TRAILING_DELTA,
        MAX_NUM_ALGO_ORDERS,
        //the maximum number of all kinds of algo orders an account is allowed to have open on a symbol.
        //The algo orders include STOP, STOP_MARKET, TAKE_PROFIT, TAKE_PROFIT_MARKET, and TRAILING_STOP_MARKET orders
        PERCENT_PRICE_BY_SIDE,//PERCENT_PRICE phased out and replaced by this
        MAX_POSITION//
    }
}

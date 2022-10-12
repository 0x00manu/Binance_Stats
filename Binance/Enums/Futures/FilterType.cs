namespace Binance.Enums.Futures
{
    public enum FilterType
    {
        PRICE_FILTER,
        //price >= minPrice
        //price <= maxPrice
        //(price-minPrice) % tickSize == 0
        MARKET_LOT_SIZE,
        //quantity >= minQty
        //quantity <= maxQty
        //(quantity-minQty) % stepSize == 0
        MAX_NUM_ORDERS,
        // the maximum number of orders an account is allowed to have open on a symbol.
        MAX_NUM_ALGO_ORDERS,
        //the maximum number of all kinds of algo orders an account is allowed to have open on a symbol.
        //The algo orders include STOP, STOP_MARKET, TAKE_PROFIT, TAKE_PROFIT_MARKET, and TRAILING_STOP_MARKET orders
        PERCENT_PRICE,
        //BUY: price <= markPrice * multiplierUp
        //SELL: price >= markPrice * multiplierDown
        MIN_NOTIONAL
        //price * quantity. Since MARKET orders have no price, the mark price is used.
    }
}
//https://binance-docs.github.io/apidocs/futures/en/#public-endpoints-info
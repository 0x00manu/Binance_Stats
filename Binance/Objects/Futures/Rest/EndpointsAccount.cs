namespace Binance.Objects.Futures.Rest
{
    public static partial class Endpoints
    {
        public const string order = burl + @$"/fapi/v1/order";//POST, GET, DELETE
        public const string dualSidePosition = burl + @"/fapi/v1/positionSide/dual";  //true": Hedge Mode; "false": One-way Mode    //GET & POST
        public const string multiAssetsMargin = burl + @"/fapi/v1/multiAssetsMargin";      //"true": Multi-Assets Mode; "false": Single-Asset Mode //GET & POST
        public const string batchOrders = burl + @"/fapi/v1/batchOrders";//POST & DELETE /fapi/v1/batchOrders?batchOrders=[{"type":"LIMIT","timeInForce":"GTC","symbol":"BTCUSDT","side":"BUY","price":"10001","quantity":"0.001"}]
        public const string candelAllOpenOrders = burl + @"/fapi/v1/allOpenOrders";//DELETE
        public const string countdownCancelAll = burl + @"/fapi/v1/countdownCancelAll"; //countdownTime=1000
        public const string openOrder = burl + @"/fapi/v1/openOrder";//origClientOrderId OR orderId
        public const string allOrders = burl + @"/fapi/v1/allOrders";//Get all account orders; active, canceled, or filled.
        public const string leverage = burl + @"/fapi/v1/leverage";
        public const string marginType = burl + @"/fapi/v1/marginType";//marginType ISOLATED, CROSSED
        public const string isolatedPositionMargin = burl + @"/fapi/v1/positionMargin";//see POSTMAN
        public const string positionMarginHistory = burl + @"/fapi/v1/positionMargin/history";
        public const string forceOrders = burl + @"/fapi/v1/forceOrders";
        public const string apiTradingStatus = burl + @"/fapi/v1/apiTradingStatus";
        public const string commissionRate = burl + @"/fapi/v1/commissionRate";
    }
}
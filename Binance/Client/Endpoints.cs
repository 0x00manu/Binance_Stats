namespace Binance.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class Endpoints
    {
        #region fields
        internal const string bUrl        = @"https://api.binance.com";
        //internal const string bUrl      = @"https://testnet.binance.vision";
        internal const string bUrl1       =  @"https://api1.binance.com";
        internal const string bUrl2       =  @"https://api2.binance.com";
        internal const string bUrl3       =  @"https://api3.binance.com";
        internal const string bUrlFutures = @"https://fapi.binance.com";
        //User endpoints
        internal const string tradeFee    = bUrl + @"/sapi/v1/asset/tradeFee";
        internal const string trades      = bUrl + @"/api/v3/trades";
        internal const string depth       = bUrl + @"/api/v3/depth";
        internal const string transfer    = bUrl +  @"/sapi/v1/asset/transfer";
        internal const string testOrder   = bUrl + @"/api/v3/order/test";
        internal const string order       = bUrl + @"/api/v3/order";
        internal const string queryOrder  = bUrl + @"/api/v3/order";
        internal const string openOrders  = bUrl + @"/api/v3/openOrders";
        internal const string allOrders   = bUrl + @"/api/v3/allOrders";
        internal const string allOrderList= bUrl + @"/api/v3/allOrderList";
        internal const string apiRestrictions = bUrl + @"/sapi/v1/account/apiRestrictions";
        internal const string spotSummary     = bUrl + @"/sapi/v1/sub-account/spotSummary";
        internal const string exchangeInfo    = bUrl + @"/api/v3/exchangeInfo";
        internal const string symbolInfo      = bUrl + @"/api/v3/exchangeInfo?symbol=";
        internal const string time            = bUrl + @"/api/v3/time";
        internal const string avgPrice        = bUrl + @"/api/v3/avgPrice";
        internal const string allCoinInfo     = bUrl + @"/sapi/v1/capital/config/getall";
        internal const string accountSnapshot = bUrl + @"/sapi/v1/accountSnapshot";
        internal const string apiTradingStatus= bUrl + @"/sapi/v1/account/apiTradingStatus";
        internal const string createListenKey = bUrl + @"/api/v3/userDataStream";
        internal const string klines          = bUrl + @"/api/v3/klines";
        #endregion

    }
}

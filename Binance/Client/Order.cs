namespace Binance.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public partial class Client
    {
        private const string testOrder      = @"/api/v3/order/test";    //POST
        private const string newOrder       = @"/api/v3/order";         //POST
        private const string cancelOrder    = @"/api/v3/order";         //DELETE
        private const string cancelAllOrders= @"/api/v3/openOrders";    //DELETE
        private const string queryOrders    = @"/api/v3/order";         //GET
        private const string currentOpen    = @"/api/v3/openOrders";     //without Symbol
        private const string allOrders      = @"/api/v3/allOrders";     //without symbol NEW/OPEN/FILLED
        private const string newOCO         = @"/api/v3/order/oco";     //POST one-cancels-other
        private const string cancelOCO      = @"/api/v3/orderList";     //DELETE
        private const string queryOCO       = @"/api/v3/orderList";     //GET
        private const string queryAllOCO    = @"/api/v3/allOrderList";  //GET
        private const string queryOpenOCO   = @"/api/v3/openOrderList"; //GET
        private const string tradeFee       = @"/sapi/v1/asset/tradeFee";
        private static string SQL_CId_to_Bin_CId(string cid){
            return cid;
        }
        /// <summary>
        /// newClientOrderID  ETHBUSD_01_SELL
        /// </summary>
        /// <param name="sym"></param>
        /// <param name="qty"></param>
        /// <param name="clientOrderID"></param>
        /// <returns name="Status"></returns>
        public Binance.Objects.Status OrderNew(
            string sym,                                        //MANDATORY
            Enums.OrderSide side,                              //MANDATORY
            double qty,                                        //mandatory for LIMIT
            double? price,                                      //mandatory for LIMIT
            string? newClientOrderID,
            Enums.OrderType? type = Enums.OrderType.LIMIT,     //MANDATORY
            Enums.TimeInForce? timeInForce = Enums.TimeInForce.GTC
        )
        {
            string BCId = $"{sym}_{newClientOrderID}_{side}";
            //var text = force.ToString();
            var queryString = $"symbol={sym}";
            queryString += $"&side={side}";
            queryString += $"&quantity={qty}";
            queryString += (price==null)?"":$"&price={price}";
            queryString += (type==null)?"":$"&type={type.ToString()}";
            queryString += (BCId==null)?"":$"&newClientOrderId={BCId}";
            queryString += (timeInForce==null)?"":$"&timeInForce={timeInForce.ToString()}";
            queryString += $"&{Objects.MyFxn.RecvWindow(5000)}{Objects.MyFxn.TimeStamp()}";
            var url = Endpoints.bUrl 
                + newOrder 
                + "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-MBX-APIKEY", this.keys.Key??"");
            var response = client.Execute(request);
            var status = new Objects.Status();
            //System.Console.WriteLine("Binance: Client: Order: "+response.Content);
            status.orderStatus = Newtonsoft.Json.JsonConvert.DeserializeObject<Objects.OrderStatus>(response.Content);
            status.error = Newtonsoft.Json.JsonConvert.DeserializeObject<Objects.Error>(response.Content);
            return status;
        }

        /// <summary>
        /// Cancel by symbol/orderId/origCleintOrderId
        /// </summary>
        /// <param name="sym"></param>
        /// <param name="origClientOrderId"></param>
        /// <param name="orderId"></param>
        /// <returns name="Status"></returns>
        public Binance.Objects.Status CancelOrder(
            string sym,
            Enums.OrderSide side,
            string? origClientOrderId,
            long? orderId=null
        )
        {
            var queryString = "";
            if(orderId==null)
            {
                queryString
                = $"symbol={sym}"
                + $"&origClientOrderId={sym}_{origClientOrderId}_{side}"
                + $"&{Objects.MyFxn.RecvWindow(5000)}{Objects.MyFxn.TimeStamp()}";
            }
            else
            {
                queryString
                = $"symbol={sym}"
                + $"&orderId={orderId.ToString()}"
                + $"&{Objects.MyFxn.RecvWindow(5000)}{Objects.MyFxn.TimeStamp()}";
            }
            var url = Endpoints.bUrl + cancelOrder + "?" + queryString + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.DELETE);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-MBX-APIKEY", this.keys.Key??"");
            //CookieContainer _cookieJar = new CookieContainer();
            //client.CookieContainer = _cookieJar;
            var response = client.Execute(request);
            Objects.Status status = new Objects.Status();
            status.orderStatus = Newtonsoft.Json.JsonConvert.DeserializeObject<Binance.Objects.OrderStatus>(response.Content);
            status.error = Newtonsoft.Json.JsonConvert.DeserializeObject<Binance.Objects.Error>(response.Content);
            return status;
        }

        /// <summary>
        /// Cancel all Open Orders on a Symbol, including OCO
        /// </summary>
        public Binance.Objects.Status OrderCancelAll(string sym, double rate, double qty)
        {
            var queryString
            = $"symbol={sym}"
            + $"&{Objects.MyFxn.RecvWindow(5000)}{Objects.MyFxn.TimeStamp()}";
            var url = Endpoints.openOrders + '?' + queryString + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.DELETE);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-MBX-APIKEY", this.keys.Key??"");
            var response = client.Execute(request);
            Objects.Status status = new Objects.Status();
            status.orderStatus = Newtonsoft.Json.JsonConvert.DeserializeObject<Objects.OrderStatus>(response.Content);
            status.error = Newtonsoft.Json.JsonConvert.DeserializeObject<Binance.Objects.Error>(response.Content);
            return status;
        }

        /// <summary>
        /// Query Orders on a Symbol
        /// </summary>
        public Objects.OrderQueryStatus? OrderQuery(
            string sym,
            Enums.OrderSide side,
            string? origClientOrderId,
            long? orderId=null
        )
        {
            var queryString = "";
            if(orderId==null)
            {
                queryString
                = $"symbol={sym}"
                + $"&origClientOrderId={sym}_{origClientOrderId}_{side}"
                + $"&{Objects.MyFxn.RecvWindow(5000)}{Objects.MyFxn.TimeStamp()}";
            }
            else
            {
                queryString
                = $"symbol={sym}"
                + $"&orderId={orderId.ToString()}"
                + $"&{Objects.MyFxn.RecvWindow(5000)}{Objects.MyFxn.TimeStamp()}";
            }
            var url = Endpoints.queryOrder
                + "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-MBX-APIKEY", this.keys.Key??"");
            var response = client.Execute(request);
            return (Newtonsoft.Json.JsonConvert.DeserializeObject<Objects.OrderQueryStatus>(response.Content));
        }

        /// <summary>
        /// Trading fee for all the symbols
        /// </summary>
        public List<Objects.TradeFee>? TradingFee()
        {
            var queryString = $"{Objects.MyFxn.RecvWindow(5000)}{Objects.MyFxn.TimeStamp()}";
            var url = Endpoints.bUrl 
                + tradeFee
                + "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-MBX-APIKEY", this.keys.Key??"");
            var response = client.Execute(request);
            return (Newtonsoft.Json.JsonConvert.DeserializeObject<List<Objects.TradeFee>>(response.Content));
        }
    }
}

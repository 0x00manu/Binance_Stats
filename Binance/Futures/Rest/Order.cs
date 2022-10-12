namespace Binance.Futures.Client
{
    using System;
    using Binance.Enums.Futures;
    public partial class Client
    {
        private const string order = "/fapi/v1/order";
        public Binance.Objects.Futures.Order? OrderStopLoss
        (
            string symbol,
            OrderSide side,
            PositionSide positionSide
        )
        {
            return OrderNew
            (
                symbol,
                side,
                positionSide,
                OrderType.STOP_MARKET,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                true,//closePosition=true
                null
            );
        }
        public Binance.Objects.Futures.Order? OrderTakeProfit
        (
            string symbol,
            OrderSide side,
            PositionSide positionSide
        )
        {
            return OrderNew
            (
                symbol,
                side,
                positionSide,
                OrderType.TAKE_PROFIT_MARKET,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                true,//closePosition=true
                null
            );
        }
        ///<summary>
        ///Change MarginType=ISOLATED if required before placing order
        ///</summary>
        public Binance.Objects.Futures.Order? OrderLimit
        (
            string symbol,
            OrderSide side,           //Enums.OrderSide.SELL
            PositionSide positionSide,//Enums.PositionSide.SHORT
            double? qty=null,
            double? price=null
        )
        {
            return OrderNew
            (
                symbol,
                side,
                PositionSide.LONG,
                OrderType.LIMIT,
                TimeInForce.GTC,
                qty,
                price
            );
        }
        
        ///<summary>
        ///to open LONG position use BUY
        ///to close LONG position use SELL
        ///to open SHORT position use SELL
        ///to close SHORT position use BUY
        ///</summary>
        public Binance.Objects.Futures.Order? OrderNew
        (
            string symbol,                              //MANDATORY
            OrderSide side,                       //MANDATORY (BUY for One-Way means LONG)
            PositionSide? positionSide,   //MANDATORY for Hedge Mode
            OrderType type,               //MANDATORY
            TimeInForce? timeInForce,             //MANDATORY for LIMIT
            double? quantity=null,                      //for LIMIT
            double? price=null,                         //for LIMIT
            WorkingType? workingType=null,
            Double? activationPrice=null,               //for TRAILING_STOP
            Double? callbackRate=null,                  //for TRAILING_STOP
            double? stopPrice=null,                     //
            ResponseType? respType=null,
            bool? closePosition=null,                   //Quantity must be zero with closePosition equals true
            bool? reduceOnly=null                       //Reduce only must be true with closePosition equals true
        )                                               //"true" or "false". default "false". Cannot be sent in Hedge Mode; cannot be sent with closePosition=true
        {
            string url = burl + order;
            string queryString
            = $"symbol={symbol}";
            queryString += $"&side={side}";
            queryString += (positionSide==null)?"" : $"&positionSide={positionSide}";
            queryString += $"&type={type}";
            queryString += (timeInForce==null)?"" : $"&timeInForce={timeInForce}";
            queryString += (quantity==null)?"" : $"&quantity={quantity}";
            queryString += (price==null)?"" : $"&price={price}";
            queryString += (workingType==null)?"" : $"&workingType={workingType}";
            queryString += (activationPrice==null)?"" : $"&activationPrice={activationPrice}";
            queryString += (callbackRate==null)?"" : $"&callbackRate={callbackRate}";
            queryString += (stopPrice==null)?"" : $"&stopPrice={stopPrice}";
            queryString += (respType==null)?"" : $"&newOrderRespType={respType}";
            queryString += (closePosition==null)?"" : $"&closePosition={closePosition}";
            queryString += (reduceOnly==null)?"" : $"&reduceOnly={reduceOnly}";//true when closing and without price
            queryString += $"&{Objects.MyFxn.RecvWindow(5000)}{Objects.MyFxn.TimeStamp()}";
            url += "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            System.Console.WriteLine(url);
            return GetPostDelete<Binance.Objects.Futures.Order>(url,RestSharp.Method.POST);
        }
        public Binance.Objects.Futures.Order? OrderCancel
        (
            string symbol,
            long? orderId=null
        )
        {
            string url = burl + order;
            string queryString = $"symbol={symbol}";
            queryString += (orderId==null)?"":$"&orderId={orderId}";
            queryString += $"&{Objects.MyFxn.TimeStamp()}";
            url += "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<Binance.Objects.Futures.Order>(url,RestSharp.Method.DELETE);
        }
        public Binance.Objects.Futures.Order? OrderCancelAll(string symbol)
        {
            string url = burl + "fapi/v1/allOpenOrders";
            string queryString = $"symbol={symbol}";
            queryString += $"&{Objects.MyFxn.TimeStamp()}";
            url += "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<Binance.Objects.Futures.Order>(url,RestSharp.Method.DELETE);
        }

        public Binance.Objects.Futures.Order? OrderQuery
        (
            string symbol,
            long? orderId=null
        )
        {
            string url = burl + order;
            string queryString = $"symbol={symbol}";
            queryString += (orderId==null)?"":$"&orderId={orderId}";
            queryString += $"&{Objects.MyFxn.TimeStamp()}";
            url += "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<Binance.Objects.Futures.Order>(url,RestSharp.Method.GET);
        }
        public Binance.Objects.Futures.Order? OrderQueryOpen
        (
            string symbol,
            long? orderId=null
        )
        {
            string url = burl + "/fapi/v1/openOrder";
            string queryString = $"symbol={symbol}";
            queryString += (orderId==null)?"":$"&orderId={orderId}";
            queryString += $"&{Objects.MyFxn.TimeStamp()}";
            url += "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<Binance.Objects.Futures.Order>(url,RestSharp.Method.GET);
        }
        public List<Binance.Objects.Futures.Order>? OrdersQueryOpen()
        {
            string url = burl + "/fapi/v1/openOrders";
            string queryString = $"&{Objects.MyFxn.TimeStamp()}";
            url += "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDeleteList<Binance.Objects.Futures.Order>(url,RestSharp.Method.GET);
        }
    }
}
/*            

//client.OrderQuery("BTCUSDT",null,71829055708); RESPONSE:
{
    "orderId":71829055708,
    "symbol":"BTCUSDT",
    "status":"NEW",
    "clientOrderId":"hreqpme4eRz4agCdY2ewJg",
    "price":"20500",
    "avgPrice":"0.00000",
    "origQty":"0.001",
    "executedQty":"0",
    "cumQuote":"0",
    "timeInForce":"GTC",
    "type":"LIMIT",
    "reduceOnly":false,
    "closePosition":false,
    "side":"SELL",
    "positionSide":"SHORT",
    "stopPrice":"0",
    "workingType":"CONTRACT_PRICE",
    "priceProtect":false,
    "origType":"LIMIT",
    "time":1661663813782,
    "updateTime":1661663813782
}
//client.OrderCancel("BTCUSDT",null,71829055708);
{
    "orderId":71829055708,
    "symbol":"BTCUSDT",
    "status":"CANCELED",
    "clientOrderId":"hreqpme4eRz4agCdY2ewJg",
    "price":"20500",
    "avgPrice":"0.00000",
    "origQty":"0.001",
    "executedQty":"0",
    "cumQty":"0",
    "cumQuote":"0",
    "timeInForce":"GTC",
    "type":"LIMIT",
    "reduceOnly":false,
    "closePosition":false,
    "side":"SELL",
    "positionSide":"SHORT",
    "stopPrice":"0",
    "workingType":"CONTRACT_PRICE",
    "priceProtect":false,
    "origType":"LIMIT",
    "updateTime":1661664959175
}
*/
/*
var status = client.OrderNew
(
    "BTCUSDT",                      //SYMBOL
    Enums.OrderSide.SELL,           //OPEN
    Enums.PositionSide.SHORT,       //SHORT
    Enums.Futures.OrderType.LIMIT,  //@PRICE not MARK
    Enums.TimeInForce.GTC,          //GOOD TILL CANCEL
    0.001,                          //PRICE
    20500                           //QUANTITY
);
{
    "orderId":71829055708,
    "symbol":"BTCUSDT",
    "status":"NEW",
    "clientOrderId":"hreqpme4eRz4agCdY2ewJg",
    "price":"20500",
    "avgPrice":"0.00000",
    "origQty":"0.001",
    "executedQty":"0",
    "cumQty":"0",
    "cumQuote":"0",
    "timeInForce":"GTC",
    "type":"LIMIT",
    "reduceOnly":false,
    "closePosition":false,
    "side":"SELL",
    "positionSide":"SHORT",
    "stopPrice":"0",
    "workingType":"CONTRACT_PRICE",
    "priceProtect":false,
    "origType":"LIMIT",
    "updateTime":1661663813782
}
*/
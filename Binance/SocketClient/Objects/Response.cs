namespace Binance.SocketClient.Objects
{
    internal class Response
    {
        protected string? result {get; set;}    //null=>success
        protected UInt32 id {get; set;}
    }
}
/*Response to request
{
"method": "SUBSCRIBE",
"params":
[
"btcusdt@aggTrade",
"btcusdt@depth"
],
"id": 1
}*/

/*OR
{
"method": "UNSUBSCRIBE",
"params":
[
"btcusdt@depth"
],
"id": 312
}*/
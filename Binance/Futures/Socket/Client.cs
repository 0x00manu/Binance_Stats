namespace Binance.Futures.Socket
{
    using System;
    using System.Threading.Tasks;
    using WebSocketSharp;
    using System.Threading;

    /// <summary>
    /// WebSocket Sharp
    /// </summary>
    public class Client
    {
        Thread pingingThread {set; get;}
        static WebSocket? ws { set; get; }
        public void Disconnect(){
            ws.Close((ushort)Enums.CLOSE_STATUS.NORMAL);
        }
        /// <summary>
        /// Stream Methods call this method
        /// </summary>
        private void Connect(string url=Objects.Endpoints.klines)
        {
            pingingThread = new Thread(new ThreadStart(HeartBeat));
            ws = new WebSocket(url);
            ws.OnError += Ws_OnError;
            ws.OnMessage += Ws_OnMessage;
            ws.OnClose += Ws_OnClose;
            ws.OnOpen += Ws_OnOpen;
            ws.Connect();
            pingingThread.Start();
        }

        /// <summary>
        /// Thread
        /// </summary>
        private static void HeartBeat()
        {
            while(true)
            {
                ws.Ping();
                Thread.Sleep(60 * 1000);
            }
        }
        virtual protected void Ws_OnOpen(object sender, EventArgs e)
        {
            Console.WriteLine($"Binance: SocketClient: Ws_OnOpen: websocket open");
        }

        virtual protected void Ws_OnClose(object sender, CloseEventArgs e)
        {
            Console.WriteLine($"Binance: SocketClient: Ws_OnClose: code: {e.Code} reason: {e.Reason}");
            if (!e.WasClean)
            {
                while (!ws.IsAlive)
                {
                    ws.Connect();
                    Thread.Sleep(10000);
                }
            }
        }        

        virtual protected void Ws_OnMessage(object sender, MessageEventArgs e)
        //override protected void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            System.Console.WriteLine($"Binance: SocketClient: Ws.OnMessage: {e.Data}");
        }

        virtual protected void Ws_OnError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine($"Binance: SocketClient: Ws_OnError: {e.Message}");
        }

        public void SuscribeTrades(string btcusdt, UInt32 id){
            var str 
            = "{\"method\": \"SUBSCRIBE\",\"params\":["
            + "\""
            + $"{btcusdt.ToLower()}"
            + $"@trade\"],\"id\": {id}}}";
            ws.Send(str);            
        }
        ///<summary>
        ///btcusdt must be in small letters
        ///</summary>
        public void SuscribeDepth(string btcusdt, UInt32 id)
        {
            var str
            = $"{{\"method\": \"SUBSCRIBE\","
            + $"\"params\":[\"{btcusdt.ToLower()}@depth5@1000ms\"],\"id\": {id}}}";
            ws.Send(str);
        }
        private void SuscribeDepth(string btcusdt, string ethbusd)
        {
            var str 
            = $"{{\"method\": \"SUBSCRIBE\","
            + $"\"params\":[\"{btcusdt.ToLower()}@depth5@1000ms\",\"{ethbusd.ToLower()}@depth5@1000ms\"],\"id\": 512}}";
            ws.Send(str);
        }
        public void StreamForceOrders()
        {
            string forceOrder = @"wss://fstream.binance.com/ws/!forceOrder@arr";
            this.Connect(forceOrder);
        }
        //TAKES lower case returns upper case
        public void StreamMarkPrice1s(string btcusdt)
        {
            string markp = $@"wss://fstream.binance.com/ws/{btcusdt.ToLower()}@markPrice@1s";
            this.Connect(markp);
        }
        ///<summary>
        ///Only one stream can be connected on one instance
        ///</summary>
        public void StreamForceOrders(string symbol)
        {
            string forceOrder = $@"wss://fstream.binance.com/ws/{symbol.ToLower()}@forceOrder";
             this.Connect(forceOrder);
        }
        private void UnSuscribeAggTrade(string btcusdt)
        {
            ws.Send(Binance.Futures.Socket.Objects.Endpoints.FUrlWS);
        }
        internal string? GetAuthForStream(string key)
        {
            var url = @"https://fapi.binance.com"+"/fapi/v1/listenKey";
            System.Console.WriteLine(url);
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.POST);
            request.AddHeader("Content-Type", "application/json");            
            request.AddHeader("User-Agent", "RestSharp");
            request.AddHeader("X-MBX-APIKEY", key);
            var response = client.Execute(request);
            System.Console.WriteLine(response.Content);
            var listen = Newtonsoft.Json.JsonConvert.DeserializeObject<Binance.Objects.ListenKey>(response.Content);
            return listen.listenKey;
        }
    }
}

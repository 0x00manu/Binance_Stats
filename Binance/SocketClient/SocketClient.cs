namespace Binance.SocketClient
{
    using System;
    using System.Threading.Tasks;
    using WebSocketSharp;           //have Newtonsoft
    using System.Threading;

    public class SocketClient
    {
        Thread pingingThread {set; get;}
        static WebSocket? ws { set; get; }
        public void Disconnect(){
            ws.Close((ushort)Enums.CLOSE_STATUS.NORMAL);
        }
        ///use SuscribeDepth instead
        public void Connect()
        {
            pingingThread = new Thread(new ThreadStart(HeartBeat));
            ws = new WebSocket(Binance.SocketClient.Objects.Endpoints.bUrlWS);
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
                Thread.Sleep(10 * 1000);
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
        //override public void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.Data);
        }

        virtual protected void Ws_OnError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine($"Binance: SocketClient: Ws_OnError: {e.Message}");
        }

        private void SuscribeAggTrade(string btcusdt)
        {
            var str = "{\"method\": \"SUBSCRIBE\",\"params\":[" + "\"" + $"{btcusdt.ToLower()}" + "@aggTrade\"],\"id\": 1}";
            System.Console.WriteLine(str);
            ws.Send(str);
        }
        public void SuscribeTrades(string btcusdt, UInt32 id){
            var str = "{\"method\": \"SUBSCRIBE\",\"params\":[" + "\"" + $"{btcusdt.ToLower()}" + "@trade\"],\"id\": 2}";
            ws.Send(str);            
        }
        ///<summary>
        ///btcusdt must be in small letters
        ///</summary>
        public void SuscribeDepth(string btcusdt, UInt32 id)
        {
            var str = 
            $"{{\"method\": \"SUBSCRIBE\","
            +$"\"params\":[\"{btcusdt.ToLower()}@depth5@1000ms\"],\"id\": {id}}}";
            ws.Send(str);
        }
        private void Suscribe2Depth(string btcusdt, string ethbusd)
        {
            var str = 
            $"{{\"method\": \"SUBSCRIBE\","
            +$"\"params\":[\"{btcusdt.ToLower()}@depth5@1000ms\",\"{ethbusd.ToLower()}@depth5@1000ms\"],\"id\": 512}}";
            ws.Send(str);
        }
        private void StopGettingAggTrade(string btcusdt)
        {
            ws.Send(Objects.Endpoints.bUrlStream);
        }

        //Partial Book Depth Streams
        //Top bids and asks, Valid are 5, 10, or 20.
        //<symbol>@depth<levels> OR <symbol>@depth<levels>@100ms
        //1000ms or 100ms

        //Diff. Depth Stream
        //Stream Name: <symbol>@depth OR <symbol>@depth@100ms
        //Update Speed: 1000ms or 100ms
        //"btcusdt@depth@100ms" only provides the change in the order book, not the order book itself (as mentioned by the other answer)
        //Use: "btcusdt@depth10@100ms" if you want to stream the book 10 best bids and 10 best asks.

    }
}
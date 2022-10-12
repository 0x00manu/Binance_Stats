namespace Binance.SocketClient.Objects
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class Endpoints
    {
        #region fields
        public static string bUrlWS = @"wss://stream.binance.com:9443/ws";
        public static string bUrlWSTest = @"wss://testnet.binance.vision/ws";
        public static string bUrlStream = @"wss://stream.binance.com:9443/stream";
        public static string bUrlStreamTest = @"wss://testnet.binance.vision/stream";

        //User endpoints
        private const string depthStreamEndpoint = "@depth";
        private const string bookTickerStreamEndpoint = "@bookTicker";
        private const string allBookTickerStreamEndpoint = "!bookTicker";
        private const string klineStreamEndpoint = "@kline";
        private const string tradesStreamEndpoint = "@trade";
        private const string aggregatedTradesStreamEndpoint = "@aggTrade";
        private const string symbolTickerStreamEndpoint = "@ticker";
        private const string allSymbolTickerStreamEndpoint = "!ticker@arr";
        private const string partialBookDepthStreamEndpoint = "@depth";
        private const string symbolMiniTickerStreamEndpoint = "@miniTicker";
        private const string allSymbolMiniTickerStreamEndpoint = "!miniTicker@arr";

        private const string executionUpdateEvent = "executionReport";
        private const string ocoOrderUpdateEvent = "listStatus";
        private const string accountPositionUpdateEvent = "outboundAccountPosition";
        private const string balanceUpdateEvent = "balanceUpdate";
        //
        #endregion

    }
}

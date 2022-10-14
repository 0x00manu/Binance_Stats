namespace Binance.Futures.Socket.Objects
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class Endpoints
    {
        #region fields
        //public static string bUrlWS = @"wss://stream.binance.com:9443/ws";
        public const string FUrlWS = @"wss://fstream.binance.com";
        //<symbol>@markPrice or <symbol>@markPrice@1s
        //Update Speed: 3000ms or 1000ms
        public const string aggTrade = @"wss://fstream.binance.com/ws/bnbusdt@aggTrade";
        public const string aggTrade_markPrice = @"wss://fstream.binance.com/stream?streams=bnbusdt@aggTrade/btcusdt@markPrice";

        public const string FUrlWS_auth = @"wss://fstream-auth.binance.com";
        public const string aggTradeAuth = @"wss://fstream-auth.binance.com/ws/btcusdt@markPrice?listenKey=";
        public const string multipleAuth = @"wss://fstream-auth.binance.com/stream?streams=btcusdt@markPrice@1s/bnbusdt@markPrice&listenKey=";
        public const string Liquidation = @"wss://fstream.binance.com/ws/ETHUSDT@forceOrder";
        public const string klines = FUrlWS + @"/ws/btcusdt@kline_1m";          //Symbol in small letters 
        public const string markPrice1s = FUrlWS + @"/ws/btcusdt@markPrice@1s"; //Symbol in small letters 
        public const string markPrice3s = FUrlWS + @"/ws/btcusdt@markPrice";    //Symbol in small letters 
        #endregion
        public static string Create<T>(string? symbolPair)
        {
            if(symbolPair==null)
            {
                return @$"wss://fstream.binance.com/ws/!{typeof(T).Name}@arr";
            }
            else
            {
                return @$"wss://fstream.binance.com/ws/{symbolPair}@{typeof(T).Name}";
            }
        }
    }
}

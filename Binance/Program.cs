namespace Binance
{
    using Binance.Futures.Socket;
    using Binance.Enums.Futures;
    class Program
    {
        public static async Task Main()
        {
            var p = new Program();
            p.SymbolStatus();
        }

        public void ExchangExample()
        {
            var c = new Client.Exchange();
            var info = Newtonsoft.Json.JsonConvert.SerializeObject(c.Info("BTCUSDT"));
            System.Console.WriteLine(info);
        }
        public void SymbolStatus()
        {
            var c = new Client.Exchange();
            var symbols = c.Info().symbols;
            foreach(var sym in symbols){
                System.Console.WriteLine($"{sym.symbol} Tallow: {sym.isSpotTradingAllowed} status:{sym.status} ocoAllow: {sym.ocoAllowed}");
            }
        }
        public void StreamExample()
        {
            var client = new Futures.Socket.Client();
            client.StreamMarkPrice1s("btcusdt");
        }
        public void BuySellDemo()
        {
            var client = new Binance.Futures.Client.Client("key",
            "secret");
            
            var status = client.OrderNew
            (
                "BTCUSDT",
                OrderSide.BUY,
                PositionSide.LONG,
                Enums.Futures.OrderType.LIMIT,
                TimeInForce.GTC,
                0.001,
                19000
            );
            
            Thread.Sleep(10000);
            client.OrderQuery("BTCUSDT",status.orderId);
            Thread.Sleep(10000);
            client.OrderCancel("BTCUSDT",status.orderId);
        }

        public void VariousRatio()
        {
            var client = new Binance.Futures.Client.Client("","");
            var interest = client.GetFuturesData<Objects.Futures.openInterestHist>
            ("ETHUSDT",Binance.Objects.Futures.Periods.OneHour,10);
            var avgInt = interest.Select(x => x.sumOpenInterest).Average();
            var avgPrice = interest.Select(x => x.sumOpenInterestValue).Average();
            interest.ForEach(x=>System.Console.WriteLine(x.sumOpenInterest+" "+x.sumOpenInterestValue+" "+x.timestamp));

            Thread.Sleep(2000);
            System.Console.WriteLine();
            var interest5 = client.GetFuturesData<Objects.Futures.openInterestHist>
            ("ETHUSDT",Binance.Objects.Futures.Periods.FiveMin,20);
            interest5.ForEach(x=>System.Console.WriteLine(x.sumOpenInterest+" "+x.sumOpenInterestValue+" "+x.timestamp));            
        }
        public void LiquidationSocket()
        {
            var fclient = new Binance.Futures.Socket.Client();
        }
        public void AccountDemo()
        {
            var client = new Binance.Futures.Client.Client("","");
            var acc = client.GetAccount();
            var ethusdt = acc.positions.Find(x=>x.symbol=="ETHUSDT");
            System.Console.WriteLine
            (
                $"symbol: {ethusdt.symbol}, "
                +$"initialMargin: {ethusdt.initialMargin}, "
                +$"maintMargin: {ethusdt.maintMargin}, "
                +$"unrealizedProfit: {ethusdt.unrealizedProfit}, "
                +$"positionInitialMargin: {ethusdt.positionInitialMargin}, "
                +$"openOrderInitialMargin: {ethusdt.openOrderInitialMargin}, "
                +$"leverage: {ethusdt.leverage}, "
                +$"isolated: {ethusdt.isolated}, "
                +$"entryPrice: {ethusdt.entryPrice}, "
                +$"maxNotional: {ethusdt.maxNotional}, "
                +$"positionSide: {ethusdt.positionSide}, "
                +$"positionAmt: {ethusdt.positionAmt}, "
                +$"notional: {ethusdt.notional}, "
                +$"isolatedWallet: {ethusdt.isolatedWallet}, "
                +$"updateTime: {ethusdt.updateTime}, "
                +$"bidNotional: {ethusdt.bidNotional}, "
                +$"askNotional: {ethusdt.askNotional}"
            );

        }
        public void NewOrderDemo()
        {
            var client = new Binance.Futures.Client.Client("key","secret");
            var status = client.OrderNew(
                "XRPUSDT",
                OrderSide.BUY,
                PositionSide.SHORT,
                OrderType.LIMIT,
                TimeInForce.GTC,
                20,
                0.34,
                //"XRP_SHORT",Not Working use null instead
                null,
                null,
                null,
                null,
                null,null,null
            );
            System.Console.WriteLine(status.status);
            System.Console.WriteLine(status.msg);
            Thread.Sleep(1000);
            var open = client.OrdersQueryOpen();
            foreach(var i in open)
            System.Console.WriteLine(i.symbol+i.msg);
        }
    }
}

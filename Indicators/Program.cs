namespace BB
{
    using System.Globalization;
    using Skender.Stock.Indicators;
    public class Program
    {
        const long ISTms = ((5*60*60) +(30*60))*1000;//+5:30
        ///add ms to UtcEpoch
        public static DateTime LocalTime(long unixtime){
            DateTime UnixEpochUTC = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return UnixEpochUTC.AddMilliseconds(unixtime).ToUniversalTime();
        }
        ///ms from 1970 till time
        public static long MilliSeconds(DateTime time)
        {
            return (long)(time - new DateTime(1970, 1, 1)).TotalMilliseconds;
        }
        public void start()
        {
            var binance = new Binance.Client.Exchange();
            var klines = binance.GetKlines("SOLUSDT","1h");

            klines.ForEach(x=>System.Console.WriteLine(x.OpenTime+ISTms+ ": "+LocalTime(x.OpenTime + ISTms)));
            /*var quotes = new List<Quote>();
            var bollingers = new List<Bollinger>();
            foreach(var k in klines)
            {
                quotes.Add(new Quote{
                    Date=LocalTime(k.OpenTime),
                    Open=(decimal)k.OpenPrice,
                    High=(decimal)k.HighPrice,                            
                    Low=(decimal)k.LowPrice,
                    Close=(decimal)k.ClosePrice,
                    Volume=(decimal)k.Volume
                });
                bollingers.Add(new Bollinger{
                    kline = k
                });
            }
            var boll = quotes.GetBollingerBands<Quote>(20,2);
            for(var i=0; i<boll.Count();i++)
            {                
                bollingers[i].Band = boll.ElementAt(i);                
            }
            for(var i=21; i<bollingers.Count();i++)
            {
                if((bollingers[i].kline.LowPrice < bollingers[i].Band.LowerBand)&&(bollingers[i].kline.ClosePrice > bollingers[i].Band.LowerBand))
                {
                    System.Console.WriteLine(LocalTime(klines[i].OpenTime));
                }
            }*/
        }
        public static void Main()
        {
            var p = new Program();
            /*
            var timeLocal = new DateTime(1970,1,1,0,0,0,DateTimeKind.Local);
            var timeUTC = new DateTime(1970,1,1,0,0,0,DateTimeKind.Utc);
            var localNow = DateTime.Now;
            var utcNow = DateTime.UtcNow;
            System.Console.WriteLine(localNow);
            System.Console.WriteLine((localNow-DateTime.UnixEpoch).TotalMilliseconds);
            System.Console.WriteLine(utcNow);
            System.Console.WriteLine((utcNow-DateTime.UnixEpoch).TotalMilliseconds+(ISTms));*/
            p.start();
        }
    }
}
namespace Binance.Futures.Client
{
    using Binance.Objects.Futures;
    using Binance.Objects.Futures.Rest;
    using Binance.Enums;
    using Newtonsoft.Json;

    ///<summary>
    ///this part of "Client" contains Exchange methods
    ///</summary>
    public partial class Client
    {
        const string burl =  @"https://fapi.binance.com";
        const string serverTime = burl + @"/fapi/v1/time";
        public const string exchangeInfo = burl + @"/fapi/v1/exchangeInfo";

        public ExchangeInfo? GetExchangeInfo()
        {
            return Get<ExchangeInfo>(exchangeInfo);
        }
        public List<FundingRate>? GetFundingRate(
            string? symbol=null,
            int? limit=null,
            long? startTime=null,
            long? endTime=null)
        {
            string fundingRate = burl + @"/fapi/v1/fundingRate";
            var str = new List<string>();
            str.Add((symbol==null)?"":$"?symbol={symbol}");
            str.Add((startTime==null)?"":$"&startTime={startTime}&endTime={endTime}");
            str.Add((limit==null)?"":$"&limit={limit}");
            foreach(var s in str)
            {
                fundingRate += s;
            }
            return GetList<FundingRate>(fundingRate);
        }
        public Binance.Objects.Futures.Rest.PremiumIndex? GetPremiumIndex(string symbol)
        {
            string fundingRate = burl + @"/fapi/v1/premiumIndex";
            fundingRate += ((symbol==null)?"":$"?symbol={symbol}");
            return Get<Binance.Objects.Futures.Rest.PremiumIndex>(fundingRate);
        }

        public long? GetServerTime()
        {            
            return Get<long>(serverTime);
        }
        ///<symmary>
        /// topLongShortPositionRatio
        /// topLongShortAccountRatio
        /// globalLongShortAccountRatio
        /// openInterestHistories
        /// takerlongshortRatio
        ///</summary>
        public List<T>? GetFuturesData<T>(string BTCUSDT,string period, int?limit=null)
        {
            string url = burl + $"/futures/data/{typeof(T).Name}";
                url += $"?";
                url += $"symbol={BTCUSDT}";
                url += $"&period={period}";
                url += (limit==null)?"":$"&limit={limit}";
            return GetList<T>(url);
        }
        ///<symmary>
        ///TRADES
        ///</summary>
        List<Trade>? GetTrades(string BTCUSDT, int limit)
        {   
            string queryString = $"symbol={BTCUSDT}&limit={limit}";
            string tradesurl = burl + @"/fapi/v1/trades";
            tradesurl
                += "?"
                + queryString;
            return GetList<Trade>(tradesurl);
        }
        ///<symmary>
        ///ORDER BOOK
        ///</summary>
        List<OrderBook>? GetDepths(string BTCUSDT, int limit)
        {   
            string queryString = $"symbol={BTCUSDT}&limit={limit}";
            string tradesurl = burl + @"/fapi/v1/depth";
            tradesurl
                += "?"
                + queryString;
            return GetList<OrderBook>(tradesurl);
        }
        public List<markPriceKlines> GetMarkPriceKlines()
        {
            var client = new RestSharp.RestClient( burl + @"/fapi/v1/markPriceKlines?symbol=ETHUSDT&interval=5m&limit=10");
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);
            var strs = JsonConvert.DeserializeObject<List<object>>(response.Content);
            var klines = new List<markPriceKlines>();
            foreach(var s in strs){
                var temp = JsonConvert.DeserializeObject<List<string>>(s.ToString());
                    klines.Add(new markPriceKlines {
                        OpenTime=long.Parse(temp[0]),
                        Open = double.Parse(temp[1]),
                        Close = double.Parse(temp[2]),
                        High = double.Parse(temp[3]),
                        Low = double.Parse(temp[4]),
                        CloseTime = long.Parse(temp[6])
                    }
                );
            }
            return klines;
        }
        ///<summary>
        ///Perpetual klines
        ///</summary>
        public List<continuousKlines> GetContinuousKlines
        (
            string ETHUSDT,
            string interval,
            ContractType contractType=ContractType.PERPETUAL,
            int? limit=null
        )
        {
            string url = burl;
                url +=  $"/fapi/v1/continuousKlines?";
                url += $"contractType={contractType}";
                url += $"&pair={ETHUSDT}";
                url += $"&interval={interval}";
                url += (limit==null)?"":$"&limit={limit}";
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);
            //System.Console.WriteLine(response.Content);
            var strs = JsonConvert.DeserializeObject<List<object>>(response.Content);
            var klines = new List<continuousKlines>();
            foreach(var s in strs){
                var temp = JsonConvert.DeserializeObject<List<string>>(s.ToString());
                    klines.Add(new continuousKlines {
                        OpenTime=long.Parse(temp[0]),
                        Open = double.Parse(temp[1]),
                        High = double.Parse(temp[2]),
                        Low = double.Parse(temp[3]),
                        Close = double.Parse(temp[4]),
                        Volume = double.Parse(temp[5]),
                        CloseTime = long.Parse(temp[6])
                    }
                );
            }
            return klines;
        }

        private List<T>? GetList<T>(string url)
        {
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);
            System.Console.WriteLine(response.Content);
            return JsonConvert.DeserializeObject<List<T>>(response.Content);
        }
        private T? Get<T>(string url)
        {
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);
            System.Console.WriteLine(response.Content);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}

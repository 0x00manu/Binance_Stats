namespace Binance.Client
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Objects;

    public partial class Exchange
    {
        public List<Trades> GetTrades(string wrxinr, int limit)
        {   
            var queryString = $"symbol={wrxinr.ToUpper()}&limit={limit}";
            var url = Endpoints.trades + "?" + queryString;
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);
            return MyFxn.ErrorHandling<Trades>(response.Content);
        }

        public OrderBook? GetOrderBook(string wrxinr, int limit)
        {
            var queryString = $"symbol={wrxinr.ToUpper()}&limit={limit}";
            var url = Endpoints.depth + "?" + queryString;
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderBook>(response.Content);
        }

        public ExchangeInfo? Info()
        {
            var url = Endpoints.exchangeInfo;
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ExchangeInfo>(response.Content);
        }

        public ExchangeInfo? Info (string BTCUSDT)
        {
            var url = Endpoints.symbolInfo + BTCUSDT.ToUpper();
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ExchangeInfo>(response.Content);
        }

        public AvgPrice? GetAvgPrice(string symbol)
        {
            var queryString = $"symbol={symbol.ToUpper()}";
            var url = Endpoints.avgPrice + "?" + queryString;
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<AvgPrice>(response.Content);
        }
        public List<Kline>? GetKlines(string symbol,string interval)
        {
            var queryString = $"symbol={symbol.ToUpper()}&interval={interval}";
            var url = Endpoints.klines + "?" + queryString;
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            var response = client.Execute(request);

            var strs = JsonConvert.DeserializeObject<List<object>>(response.Content);
            var klines = new List<Objects.Kline>();
            foreach(var s in strs)
            {
                var temp = JsonConvert.DeserializeObject<List<string>>(s.ToString());
                klines.Add(new Objects.Kline
                {
                    OpenTime = long.Parse(temp[0]),
                    OpenPrice = double.Parse(temp[1]),
                    HighPrice = double.Parse(temp[2]),
                    LowPrice = double.Parse(temp[3]),
                    ClosePrice = double.Parse(temp[4]),
                    Volume = long.Parse(temp[6])
                });
            }
            return klines;

        }
    }
}
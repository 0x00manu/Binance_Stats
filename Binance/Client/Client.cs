namespace Binance.Client
{
    using Newtonsoft.Json;

    public partial class Client//:Interfaces.IKeys
    {
        private Interfaces.Keys keys {get; set;}
        public Client(string generalkey, string generalSecret)
        {   
            keys = new Interfaces.Keys();
            this.keys.Key = generalkey;
            this.keys.Secret = generalSecret;
        }

        public Binance.Objects.SnapShot? FundDetails(Binance.Enums.AccountType type)
        {
            string queryString 
                = $"type={type}"
                + $"&{Objects.MyFxn.RecvWindow(15000)}{Objects.MyFxn.TimeStamp()}";
            var url = Endpoints.accountSnapshot + "?" + queryString + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");           
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-MBX-APIKEY", this.keys.Key??"");
            var response = client.Execute(request);
            System.Console.WriteLine(response.Content);
            return JsonConvert.DeserializeObject<Binance.Objects.SnapShot>(response.Content);
        }

        internal Objects.ListenKey? GetAuthForStream()
        {
            string queryString = Objects.MyFxn.RecvWindow(5000) + Objects.MyFxn.TimeStamp();
            var url = Endpoints.createListenKey;
            System.Console.WriteLine(url);
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(RestSharp.Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-MBX-APIKEY", this.keys.Key??"");
            var response = client.Execute(request);
            System.Console.WriteLine(response.Content);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Objects.ListenKey>(response.Content);
        }
    }
}
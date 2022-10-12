namespace Binance.Futures.Client
{
    using Binance.Objects.Futures;
    public partial class Client
    {
        public const string dualSidePosition = burl + @"/fapi/v1/positionSide/dual";

        public Account? GetAccount()
        {
            string url = burl + @"/fapi/v2/account";
            string queryString = $"{Objects.MyFxn.TimeStamp()}";
            url += "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<Account>(url,RestSharp.Method.GET);
        }
        ///with/without symbol
        public List<Income>? GetIncome
        (
            string? symbol=null,
            Binance.Enums.Futures.IncomeType? incomeType=null,
            long? startTime=null,
            long? endTime=null
        )
        {
            string url = burl + "/fapi/v1/income";
            string queryString = "";
            queryString += (symbol==null)?"":$"symbol={symbol}";
            queryString += (symbol==null)?$"incomeType={incomeType.ToString()}":$"&incomeType={incomeType.ToString()}";
            queryString += (startTime==null)?"":$"&startTime={startTime}&endTime={endTime}";
            queryString += $"{Objects.MyFxn.TimeStamp()}";
            url += "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDeleteList<Income>(url,RestSharp.Method.GET);
        }
        public List<Income>? GetIncome(Binance.Enums.Futures.IncomeType? incomeType, long? startTime, long? endTime)
        {
            string url = burl + "/fapi/v1/income";
            string queryString = "";
            queryString += (incomeType==null)?"":$"incomeType={incomeType.ToString()}";
            queryString += (startTime==null)?"":$"&startTime={startTime}&endTime={endTime}";
            url += "?" 
                + queryString 
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDeleteList<Income>(url,RestSharp.Method.GET);
        }
        ///<summary>
        ///Hedge gives Long and Short position risk thus a List<PositionRisk>
        ///</summary>
        public List<PositionRisk>? GetPositionRisks(string? symbol)
        {
            string url = burl + "/fapi/v2/positionRisk";
            string queryString = "";
            queryString += (symbol==null)?"":$"symbol={symbol}";
            queryString += $"{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDeleteList<PositionRisk>(url,RestSharp.Method.GET);
        }

        public List<UserTrade>? GetUserTrades(string symbol)
        {
            string url = burl + "/fapi/v1/userTrades";
            string queryString = $"symbol={symbol}{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDeleteList<UserTrade>(url,RestSharp.Method.GET);
        }
        public Balance? GetBalance(string symbol)
        {
            string url = burl + "/fapi/v2/balance";
            string queryString = $"{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<Balance>(url,RestSharp.Method.GET);
        }
        public LeverageBracket? GetLeverageBracket(string? symbol)
        {
            string url = burl + "/fapi/v1/leverageBracket";
            string queryString = "";
            queryString += (symbol==null)?"":$"symbol={symbol}";
            queryString += $"{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<LeverageBracket>(url,RestSharp.Method.GET);
        }
        public MultiAssetsMargin? GetMultiAssetsMargin()
        {
            string url = burl + "/fapi/v1/multiAssetsMargin";
            string queryString = $"{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<MultiAssetsMargin>(url,RestSharp.Method.GET);
        }
        public List<LeverageBracket>? GetCommissionRate()
        {
            string url = burl + "/fapi/v1/commissionRate";
            string queryString = $"{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDeleteList<LeverageBracket>(url,RestSharp.Method.GET);
        }

        ///<summary>
        ///takes signed url and GET/POST/DELETE method
        ///</summary>
        private T? GetPostDelete<T>(string url, RestSharp.Method method)
        {
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(method);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-MBX-APIKEY", this.keys.Key??"");
            var response = client.Execute(request);
            System.Console.WriteLine("getPostDelete: "+response.Content);
            return(Newtonsoft.Json.JsonConvert.DeserializeObject<T>(response.Content));
        }
        ///<summary>
        ///takes signed url and GET/POST/DELETE method returns list
        ///</summary>
        private List<T>? GetPostDeleteList<T>(string url, RestSharp.Method method)
        {
            var client = new RestSharp.RestClient(url);
            var request = new RestSharp.RestRequest(method);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-MBX-APIKEY", this.keys.Key??"");
            var response = client.Execute(request);
            return(Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(response.Content));
        }
    }
}

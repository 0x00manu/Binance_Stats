namespace Binance.Futures.Client
{
    using Binance.Enums.Futures;
    public partial class Client
    {
        private const string marginTypeEP = "/fapi/v1/marginType";
        private const string leverageEP = "/fapi/v1/leverage";
        private const string apiTradingStatusEP = "/fapi/v1/apiTradingStatus";
        private const string positionMarginHistoryEP = "/fapi/v1/positionMargin/history";
        private const string positionSideEP = "/fapi/v1/positionSide/dual";
        public MarginType? GetSetMarginType
        (
            string symbol,
            MarginType? marginType=null
        )
        {
            string url = burl + marginTypeEP;
            string queryString = $"symbol={symbol}";
            queryString += (marginType==null)?"":$"&marginType={marginType}";
            queryString += $"{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<MarginType>(url,(marginType==null)?RestSharp.Method.GET:RestSharp.Method.POST);
        }
        public Objects.Futures.Leverage? GetSetLeverage
        (
            string symbol,
            int? leverage=null
        )
        {
            string url = burl + leverageEP;
            string queryString = $"symbol={symbol}";
            queryString += (leverage==null)?"":$"&leverage={leverage}";
            queryString += $"{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<Objects.Futures.Leverage>(url,(leverage==null)?RestSharp.Method.GET:RestSharp.Method.POST);
        }
        public Objects.Futures.PositionMargin? GetSetPositionMargin
        (
            string symbol,
            PositionSide positionSide,
            byte? type,//=1 add position margin, 2 reduce position margin
            double? amount=null
        )
        {
            string url = burl + marginTypeEP;
            string queryString = $"symbol={symbol}";
            queryString += $"&positionSide={positionSide}";
            queryString += (amount==null)?"":$"&amount={amount}";
            queryString += (type==null)?"":$"&type={type}";
            queryString += $"{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<Objects.Futures.PositionMargin>(url,(amount==null)?RestSharp.Method.GET:RestSharp.Method.POST);
        }
        public Objects.Futures.DualSidePosition? GetSetPositionMode(bool? dual=null)
        {
            string url = burl + positionSideEP;
            string queryString = (dual==null)?"":$"dualSidePosition={dual}";
            queryString += $"{Objects.MyFxn.TimeStamp()}";
            url += "?"
                + queryString
                + Objects.MyFxn.SignatureStamp(queryString, this.keys.Secret??"");
            return GetPostDelete<Objects.Futures.DualSidePosition>(url,(dual==null)?RestSharp.Method.GET:RestSharp.Method.POST);
        }
    }
}

namespace Binance.Objects
{
    public class Filters
    {
        public Binance.Enums.FilterType FilterType { get; set; }
        //PriceFilter 
        public double minPrice { get; set; }
        public double maxPrice { get; set; }
        public double tickSize { get; set; }
        //PercentFilter 
        public double multiplierUp { get; set; }
        public double multiplierDown { get; set; }
        public double avgPriceMins { get; set; }
        //LotSize
        public double minQty { get; set; }
        public double maxQty { get; set; }
        public double stepSize { get; set; }
        //MinNotional 
        public double minNotional { get; set; }
        public bool applyToMarket { get; set; }
        //public int avgPriceMins { get; set; }
        //IcebergParts 
        public int limit { get; set; }
        //MarketLotSize 
        //TrailingDelta 
        public int minTrailingAboveDelta { get; set; }
        public int maxTrailingAboveDelta { get; set; }
        public int minTrailingBelowDelta { get; set; }
        public int maxTrailingBelowDelta { get; set; }

        //public class MaxNumOrders : Filters
        public int maxNumOrders { get; set; }
        //public class MaxNumAlgoOrders : Filters
        public int maxNumAlgoOrders { get; set; }

    }

    public class PriceFilter : Filters
    {
        public new Binance.Enums.FilterType FilterType = Binance.Enums.FilterType.PRICE_FILTER;
        public new double minPrice { get; set; }
        public new double maxPrice { get; set; }
        public new double tickSize { get; set; }
    }

    public class PercentFilter : Filters
    {
        public new Binance.Enums.FilterType FilterType = Binance.Enums.FilterType.PERCENT_PRICE;
        public new double multiplierUp { get; set; }
        public new double multiplierDown { get; set; }
        public new double avgPriceMins { get; set; }
    }
    public class LotSize : Filters
    {
        public new Binance.Enums.FilterType FilterType = Binance.Enums.FilterType.LOT_SIZE;
        public new double minQty { get; set; }
        public new double maxQty { get; set; }
        public new double stepSize { get; set; }
    }
    public class MinNotional : Filters
    {
        public new Binance.Enums.FilterType FilterType = Binance.Enums.FilterType.MIN_NOTIONAL;
        public new double minNotional { get; set; }
        public new bool applyToMarket { get; set; }
        public new int avgPriceMins { get; set; }
    }
    public class IcebergParts : Filters
    {
        public new Binance.Enums.FilterType FilterType = Binance.Enums.FilterType.ICEBERG_PARTS;
        public new int limit { get; set; }
    }
    public class MarketLotSize : Filters
    {
        public new Binance.Enums.FilterType FilterType = Binance.Enums.FilterType.MARKET_LOT_SIZE;
        public new double minQty { get; set; }
        public new double maxQty { get; set; }
        public new double stepSize { get; set; }
    }
    public class TrailingDelta : Filters
    {
        public new Binance.Enums.FilterType FilterType = Binance.Enums.FilterType.TRAILING_DELTA;
        public new int minTrailingAboveDelta { get; set; }
        public new int maxTrailingAboveDelta { get; set; }
        public new int minTrailingBelowDelta { get; set; }
        public new int maxTrailingBelowDelta { get; set; }
    }
    public class MaxNumOrders : Filters
    {
        public new Binance.Enums.FilterType FilterType = Binance.Enums.FilterType.MAX_NUM_ORDERS;
        public new int maxNumOrders { get; set; }
    }
    public class MaxNumAlgoOrders : Filters
    {
        public new Binance.Enums.FilterType FilterType = Binance.Enums.FilterType.MAX_NUM_ALGO_ORDERS;
        public new int maxNumAlgoOrders { get; set; }
    }
}
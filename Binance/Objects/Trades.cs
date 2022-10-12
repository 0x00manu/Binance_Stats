namespace Binance.Objects
{
    public class Trades
    {
        public long id { get; set; }
        public double price { get; set; }
        public double qty { get; set; }
        public double quoteQty { get; set; }
        public long time { get; set; }
        public bool isBuyerMaker { get; set; }
        public bool isBestMatch { get; set; }
    }

}
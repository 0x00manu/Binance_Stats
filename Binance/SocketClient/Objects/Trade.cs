namespace Binance.SocketClient.Objects
{
        //Stream Name: <symbol>@trade //Update Speed: Real-time
    public class Trade
    {
        public string? e { get; set; }  // Event type  use it for Polymorphism
        public long E { get; set; }     // Event time
        public string? s { get; set; }  // Symbol
        public int t { get; set; }      // Trade ID
        public double p { get; set; }   //price
        public double q { get; set; }   //quantity
        public string? X { get; set; }   // "X":"MARKET"
        public bool m { get; set; }     // Ignore
    }
}

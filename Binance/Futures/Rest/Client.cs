namespace Binance.Futures.Client
{
    public partial class Client//:Interfaces.IKeys
    {
        private Interfaces.Keys keys {get; set;}
        public Client()
        {
            keys = new Interfaces.Keys();
            keys.Key = "";
            keys.Secret = "";
        }
        public Client(string generalkey, string generalSecret)
        {   
            keys = new Interfaces.Keys();
            keys.Key = generalkey;
            keys.Secret = generalSecret;
        }
    }
}
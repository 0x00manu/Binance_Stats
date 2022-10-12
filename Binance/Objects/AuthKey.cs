namespace Binance.Objects
{
    /// <summary>
    /// auth_key key generate for stream for "timeout_duration"
    /// </summary>
    public class AuthKey
    {
        public string? auth_key { get; set; }
        public int timeout_duration { get; set; }
    }
}

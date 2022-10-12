namespace Binance.Objects.Futures
{
    public static class Periods
    {
        public const string? FiveMin = "FiveMin";
        public const string? FifteenMin = "FifteenMin";
        public const string? ThirtyMin = "ThirtyMin";
        public const string? OneHour = "OneHour";
        public const string? TwoHour = "TwoHour";
        public const string? FourHour = "FourHour";
        public const string? SixHour = "SixHour";
        public const string? TwelveHour = "TwelveHour";
        public const string? OneDay = "OneDay";
        public static string? Convert(string? str)
        {
            switch (str)
            {
                case FiveMin:    str = "5m";     break;
                case FifteenMin: str = "15m";    break;
                case ThirtyMin:  str = "30m";    break;
                case OneHour:    str = "1h";     break;
                case TwoHour:    str = "2h";     break;
                case FourHour:   str = "4h";     break;
                case SixHour:    str = "6h";     break;
                case TwelveHour: str = "12h";    break;
                case OneDay:     str = "1d";     break;
                default:         str = "5m";     break;
            }
            return str;
        }
    }
}

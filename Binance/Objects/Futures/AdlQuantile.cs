namespace Binance.Objects.Futures
{
    public class AdlQuantile
    {
        // if the positions of the symbol are crossed margined in Hedge Mode, "LONG" and "SHORT" will be returned a same quantile value, and "HEDGE" will be returned instead of "BOTH".
        int LONG {get; set;}
        int SHORT {get; set;}
        int HEDGE {get; set;}
    }
    
    public class AdlQuantiles
    {
        string? symbol {get; set;}
        AdlQuantile? adlQuantile {get; set;}
    }
}
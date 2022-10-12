namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceAdlQuantile
    {
        // if the positions of the symbol are crossed margined in Hedge Mode, "LONG" and "SHORT" will be returned a same quantile value, and "HEDGE" will be returned instead of "BOTH".
        int LONG {get; set;}
        int SHORT {get; set;}
        int HEDGE {get; set;}
    }
    
    public interface IBinanceAdlQuantiles
    {
        string? symbol {get; set;}
        AdlQuantile? adlQuantile {get; set;}
    }
}
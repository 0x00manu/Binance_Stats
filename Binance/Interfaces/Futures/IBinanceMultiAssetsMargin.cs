namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceMultiAssetsMargin
    {
        bool multiAssetsMargin {get; set;}// "true": Multi-Assets Mode; "false": Single-Asset Mode
    }
}
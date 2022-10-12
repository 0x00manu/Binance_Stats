namespace Binance.Interfaces.Futures
{
    using Binance.Objects.Futures;
    public interface IBinanceBrackets
    {
        public double bracket {get; set;}            // Notional bracket
        public Int16 initialLeverage {get; set;}     // Max initial leverage for this bracket
        public double notionalCap {get; set;}        // Cap notional of this bracket
        public double notionalFloor {get; set;}      // Notional threshold of this bracket 
        public double maintMarginRatio {get; set;}   // Maintenance ratio for this bracket
        public double cum {get; set;}                // Auxiliary number for quick calculation 
    }
    public interface IBinanceLeverageBracket
    {
        public string? symbol {get; set;}
        public List<Brackets>? brackets {get; set;}
        
    }
}
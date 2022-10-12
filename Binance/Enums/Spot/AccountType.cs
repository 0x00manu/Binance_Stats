namespace Binance.Enums
{
    /// <summary>
    /// Type of account
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Spot account type
        /// </summary>
        SPOT,
        /// <summary>
        /// Margin account type
        /// </summary>>
        MARGIN,
        /// <summary>
        /// Futures account type
        /// </summary>
        FUTURES,
        /// <summary>
        /// Leveraged account type
        /// </summary>
        LEVERAGED,
        /// <summary>
        /// See https://github.com/binance/binance-spot-api-docs/blob/master/rest-api.md#enum-definitions
        /// </summary>
        TRD_GRP_002
    }
}

namespace Binance.Objects
{
    /// <summary>
    /// market asset, a part of market-status
    /// </summary>
    class Assets                                //"assets": [{
    {
        string? type { get; set; }               //"type": "inr",              //asset code
        string? name { get; set; }               //"name": "Rupee",            //Display name of asset
        double withdrawFee { get; set; }       //"withdrawFee": 0,           //Withdrawal fee of asset
        double minWithdrawAmount { get; set; } //"minWithdrawAmount": 50,    //Minimum withdrawal amount in a single transaction
        double maxWithdrawAmount { get; set; } //"maxWithdrawAmount": 50000, //Maximum withdrawal amount in a single transaction
        double minDepositAmount { get; set; }  //"minDepositAmount": 500,    //This is the min Deposit amount that will be accepted as deposit
        int confirmation { get; set; }          //"confirmation": 5,          //Is the min number of block height needed to confirm a block chain deposit transaction.
        string? deposit { get; set; }            //"deposit": "enabled",       //Denotes whether deposit is enabled or disabled
        string? withdrawal { get; set; }         //"withdrawal": "enabled"     //Denotes whether withdrawal is enabled or disabled
    }

}
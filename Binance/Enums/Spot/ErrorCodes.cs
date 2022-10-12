namespace Binance.Enums
{
    public enum ErrorCodes
    {
                                    //10xx - General Server or Network issues
        UNKNOWN = -1000,            //An unknown error occured while processing the request.
        DISCONNECTED = -1001,       //Internal error; unable to process your request.Please try again.
        UNAUTHORIZED = -1002,       //You are not authorized to execute this request.
        TOO_MANY_REQUESTS = -1003,  //Too many requests queued.
                                    //Too much request weight used; please use the websocket for live updates to avoid polling the API.
                                    //Too much request weight used; current limit is %s request weight per %s %s. Please use the websocket for live updates to avoid polling the API.
                                    //Way too much request weight used; IP banned until %s. Please use the websocket for live updates to avoid bans.
        UNEXPECTED_RESP = -1006,    //An unexpected response was received from the message bus. Execution status unknown.
        TIMEOUT = -1007,            //Timeout waiting for response from backend server. Send status unknown; execution status unknown.
        LESS_THEN_10 = -1013,       //total amount must be greater then 10USDT          
        UNKNOWN_ORDER_COMPOSITION = -1014, //Unsupported order combination.
        TOO_MANY_ORDERS = -1015,        //Too many new orders.
                                        //Too many new orders; current limit is %s orders per %s.
        SERVICE_SHUTTING_DOWN = -1016,  //This service is no longer available.
        UNSUPPORTED_OPERATION = -1020,  //This operation is not supported.
        INVALID_TIMESTAMP = -1021,      //Timestamp for this request is outside of the recvWindow.
                                        //Timestamp for this request was 1000ms ahead of the server's time.
        INVALID_SIGNATURE = -1022,      //Signature for this request is not valid.
                                        //11xx - Request issues
        ILLEGAL_CHARS = -1100,          //Illegal characters found in a parameter.
                                        //Illegal characters found in parameter '%s'; legal range is '%s'.
        TOO_MANY_PARAMETER = -1101,     //Too many parameters sent for this endpoint.
                                        //Too many parameters; expected '%s' and received '%s'.
                                        //Duplicate values for a parameter detected.
        MANDATORY_PARAM_EMPTY_OR_MALFORMED = -1102,//A mandatory parameter was not sent, was empty/null, or malformed.
                                        //Mandatory parameter '%s' was not sent, was empty/null, or malformed.
                                        //Param '%s' or '%s' must be sent, but both were empty/null!
        UNKNOWN_PARAM = -1103,          //An unknown parameter was sent.
        UNREAD_PARAMETERS = -1104,      //Not all sent parameters were read.
                                        //Not all sent parameters were read; read '%s' parameter(s) but was sent '%s'.
        PARAM_EMPTY = -1105,            //A parameter was empty.
                                        //Parameter '%s' was empty.
        PARAM_NOT_REQUIRED = -1106,     //A parameter was sent when not required.
                                        //Parameter '%s' sent when not required.
        BAD_PRECISION = -1111,          //Precision is over the maximum defined for this asset.
        NO_DEPTH = -1112,               //No orders on book for symbol.
        TIF_NOT_REQUIRED = -1114,       //TimeInForce parameter sent when not required.
        INVALID_TIF = -1115,            //Invalid timeInForce.
        INVALID_ORDER_TYPE = -1116,     //Invalid orderType.
        INVALID_SIDE = -1117,           //Invalid side.
        EMPTY_NEW_CL_ORD_ID = -1118,    //New client order ID was empty.
        EMPTY_ORG_CL_ORD_ID = -1119,    //Original client order ID was empty.
        BAD_INTERVAL = -1120,           //Invalid interval.
        BAD_SYMBOL = -1121,             //Invalid symbol.
        INVALID_LISTEN_KEY = -1125,     //This listenKey does not exist.
        MORE_THAN_XX_HOURS = -1127,     //Lookup interval is too big.
                                        //More than %s hours between startTime and endTime.
        OPTIONAL_PARAMS_BAD_COMBO = -1128,//Combination of optional parameters invalid.
        INVALID_PARAMETER = -1130,      //Invalid data sent for a parameter.
        //                              //Data sent for parameter '%s' is not valid.
        ERROR_MSG_RECEIVED = -1010,
        NEW_ORDER_REJECTED = -2010,     //NEW_ORDER_REJECTED
        CANCEL_REJECTED = -2011,        //CANCEL_REJECTED
        //
        NO_SUCH_ORDER = -2013,          //Order does not exist.
        BAD_API_KEY_FMT = -2014,        //API-key format invalid.
        REJECTED_MBX_KEY = -2015,       //Invalid API-key, IP, or permissions for action.
        NO_TRADING_WINDOW = -2016,      //No trading window could be found for the symbol. Try ticker/24hrs instead.
    }
}

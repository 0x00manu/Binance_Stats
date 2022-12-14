namespace Binance.Futures.Socket.Enums
{
    public enum Errors
    {
        UNKNOWN = -1000,
        DISCONNECTED = -1001,
        UNAUTHORIZED = -1002,
        TOO_MANY_REQUESTS = -1003,
        DUPLICATE_IP = -1004,
        NO_SUCH_IP = -1005,
        UNEXPECTED_RESP = -1006,
        TIMEOUT = -1007,
        ERROR_MSG_RECEIVED = -1010,
        NON_WHITE_LIST = -1011,
        INVALID_MESSAGE = -1013,
        UNKNOWN_ORDER_COMPOSITION = -1014,
        TOO_MANY_ORDERS = -1015,
        SERVICE_SHUTTING_DOWN = -1016,
        UNSUPPORTED_OPERATION = -1020,
        INVALID_TIMESTAMP = -1021,
        INVALID_SIGNATURE = -1022,
        START_TIME_GREATER_THAN_END_TIME = -1023,
        ILLEGAL_CHARS = -1100,
        TOO_MANY_PARAMETERS = -1101,
        MANDATORY_PARAM_EMPTY_OR_MALFORMED = -1102,
        UNKNOWN_PARAM = -1103,
        UNREAD_PARAMETERS = -1104,
        PARAM_EMPTY = -1105,
        PARAM_NOT_REQUIRED = -1106,
        BAD_ASSET = -1108,
        BAD_ACCOUNT = -1109,
        BAD_INSTRUMENT_TYPE = -1110,
        BAD_PRECISION = -1111,
        NO_DEPTH = -1112,
        WITHDRAW_NOT_NEGATIVE = -1113,
        TIF_NOT_REQUIRED = -1114,
        INVALID_TIF = -1115,
        INVALID_ORDER_TYPE = -1116,
        INVALID_SIDE = -1117,
        EMPTY_NEW_CL_ORD_ID = -1118,
        EMPTY_ORG_CL_ORD_ID = -1119,
        BAD_INTERVAL = -1120,
        BAD_SYMBOL = -1121,
        INVALID_LISTEN_KEY = -1125,
        MORE_THAN_XX_HOURS = -1127,
        OPTIONAL_PARAMS_BAD_COMBO = -1128,
        INVALID_PARAMETER = -1130,
        INVALID_NEW_ORDER_RESP_TYPE = -1136,
        NEW_ORDER_REJECTED = -2010,
        CANCEL_REJECTED = -2011,
        NO_SUCH_ORDER = -2013,
        BAD_API_KEY_FMT = -2014,
        REJECTED_MBX_KEY = -2015,
        NO_TRADING_WINDOW = -2016,
        BALANCE_NOT_SUFFICIENT = -2018,
        MARGIN_NOT_SUFFICIEN = -2019,
        UNABLE_TO_FILL = -2020,
        ORDER_WOULD_IMMEDIATELY_TRIGGER = -2021,
        REDUCE_ONLY_REJECT = -2022,
        USER_IN_LIQUIDATION = -2023,
        POSITION_NOT_SUFFICIENT = -2024,
        MAX_OPEN_ORDER_EXCEEDED = -2025,
        REDUCE_ONLY_ORDER_TYPE_NOT_SUPPORTED = -2026,
        MAX_LEVERAGE_RATIO = -2027,
        MIN_LEVERAGE_RATIO = -2028,
    }
}
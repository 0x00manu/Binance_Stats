namespace Binance.SocketClient.Enums
{
    public enum CLOSE_STATUS
    {
        NOSTATUS = 0,
        NORMAL = 1000,
        GOINGAWAY = 1001,
        PROTOCOL_ERR = 1002,
        UNACCEPTABLE_OPCODE = 1003,
        RESERVED = 1004,
        NO_STATUS = 1005,
        ABNORMAL_CLOSE = 1006,
        INVALID_PAYLOAD = 1007,
        POLICY_VIOLATION = 1008,
        MESSAGE_TOO_LARGE = 1009,
        EXTENSION_REQUIRED = 1010,
        UNEXPECTED_CONDITION = 1011,
        TLS_FAILURE = 1015,
        CLIENT_TRANSACTION_DONE = 2000,
        NOSTATUS_CONTEXT_DESTROY = 9999,
    };
}

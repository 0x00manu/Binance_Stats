namespace Binance.Objects
{
    public class SnapShot
    {
        public int code { get; set; }
        public string? msg { get; set; }
        public List<SnapshotVo>? snapshotVos { get; set; }
    }
    public class SnapshotVo
    {
        public Data? data { get; set; }
        public string? type { get; set; }
        public long updateTime { get; set; }
    }
    public class Data
    {
        public List<Balance>? balances { get; set; }
        public string? totalAssetOfBtc { get; set; }
    }
    public class Balance
    {
        public string? asset { get; set; }
        public double free { get; set; }
        public double locked { get; set; }
    }
}    
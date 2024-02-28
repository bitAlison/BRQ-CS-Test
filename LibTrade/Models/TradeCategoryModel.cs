using LibTrade.Contracts;

namespace LibTrade.Model
{
    public class TradeCategoryModel : ITradeCategory
    {
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public string Category { get; set; }
    }
}

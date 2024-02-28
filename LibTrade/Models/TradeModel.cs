using LibTrade.Contracts;

namespace LibTrade.Model
{
    public class TradeModel : ITrade
    {
        public double Value { get; set; }
        public string ClientSector { get; set; }
    }
}

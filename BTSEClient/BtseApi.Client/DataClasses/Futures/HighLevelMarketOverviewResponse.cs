using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class MarketSummaryResponse
    {
        public string Symbol { get; set; } // "BTCPFC"
        public decimal Last { get; set; } // 7253
        public decimal LowestAsk { get; set; } // 7254
        public decimal HighestBid { get; set; } // 7252.5
        public decimal OpenInterest { get; set; } // 83617
        public decimal OpenInterestUSD { get; set; } // 606493.39
        public decimal PercentageChange { get; set; } // -1.5809
        public decimal Volume { get; set; } // 16442583.015
        public decimal High24Hr { get; set; } // 7396.5
        public decimal Low24Hr { get; set; } // 7171
        public string Base { get; set; } // "BTC"
        public string Quote { get; set; } // "USD"
        public decimal ContractStart { get; set; } // 0
        public decimal ContractEnd { get; set; } // 0
        public bool Active { get; set; } // false
        public bool TimeBasedContract { get; set; } // false
        public decimal OpenTime { get; set; } // 0
        public decimal CloseTime { get; set; } // 0
        public decimal StartMatching { get; set; } // 0
        public decimal InactiveTime { get; set; } // 0
        public decimal FundingRate { get; set; } // 0
        public decimal ContractSize { get; set; } // 0.001
        public decimal MaxPosition { get; set; } // 0
        public decimal MinValidPrice { get; set; } // 0
        public decimal MinPriceIncrement { get; set; } // 0
        public decimal MinOrderSize { get; set; } // 0
        public decimal MaxOrderSize { get; set; } // 0
        public decimal MinRiskLimit { get; set; } // 100000
        public decimal MaxRiskLimit { get; set; } // 1000000
        public decimal MinSizeIncrement { get; set; } // 0
        public List<string> AvailableSettlement { get; set; }
        public string MarketSettingsData { get; set; } // null
        public string MarketDetail { get; set; } // null
    }
}

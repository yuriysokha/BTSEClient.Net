using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class PositionResponse
    {
        public int MarginType{ get; set; }
        public decimal EntryPrice { get; set; }
        public decimal MarkPrice { get; set; }
        public string Symbol { get; set; }
        public string Side { get; set; }
        public decimal OrderValue { get; set; }
        public string SettleWithAsset { get; set; }
        public decimal UnrealizedProfitLoss { get; set; }
        public decimal TotalMaintenanceMargin { get; set; }
        public string Size { get; set; }
        public decimal LiquidationPrice { get; set; }
        public decimal IsolatedLeverage { get; set; }
        public decimal AdlScoreBucket { get; set; }
        public string LiquidationInProgress { get; set; }
        public long Timestamp { get; set; }
        public decimal CurrentLeverage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class FillsHistoryResponse
    {
        public string TradeId { get; set; }
        public string OrderId { get; set; }
        public string UserName { get; set; }
        public string Side { get; set; }
        public int OrderType { get; set; }
        public int TriggerType { get; set; }
        public decimal Price { get; set; }
        public decimal Size { get; set; }
        public decimal FilledPrice { get; set; }
        public decimal FilledSize { get; set; }
        public decimal TriggerPrice { get; set; }
        public string Base { get; set; }
        public string Quote { get; set; }
        public string Symbol { get; set; }
        public string FeeCurrency { get; set; }
        public string FeeAmount { get; set; }
        public string Wallet { get; set; }
        public decimal RealizePnl { get; set; }
        public decimal Total { get; set; }
        public long SerialId { get; set; }
        public long TimeStamp { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class OrderHistoryResponse
    {
        public string Base { get; set; }
        public string clOrderID { get; set; }
        public decimal feeAmount { get; set; }
        public string feeCurrency { get; set; }
        public decimal filledPrice { get; set; }
        public decimal filledSize { get; set; }
        public string orderId { get; set; }
        public int orderType { get; set; }
        public decimal price { get; set; }
        public string quote { get; set; }
        public decimal realizedPnl { get; set; }
        public long serialId { get; set; }
        public string side { get; set; }
        public decimal size { get; set; }
        public string symbol { get; set; }
        public long timestamp { get; set; }
        public decimal total { get; set; }
        public string tradeId { get; set; }
        public decimal triggerPrice { get; set; }
        public int triggerType { get; set; }
        public string username { get; set; }
        public string wallet { get; set; }
    }
}

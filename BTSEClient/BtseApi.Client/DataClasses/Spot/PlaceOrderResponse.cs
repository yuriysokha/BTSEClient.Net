using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class PlaceOrderResponse
    {
        public string Status { get; set; }
        public string OrderType { get; set; }
        public string OrderId { get; set; }
        public long TimeStamp { get; set; }
        public bool Trigger { get; set; }
        public string Message { get; set; }
        public decimal AverageFillPrice { get;  set; }
        public decimal FillSize { get; set; }
        public string ClOrderID { get; set; }
        public decimal Deviation { get; set; }
        public bool? PostOnly { get; set; }
        public decimal Price { get; set; }
        public string Side { get; set; }
        public decimal Size { get; set; }
        public decimal Stealth { get; set; }
        public decimal StopPrice { get; set; }
        public string Symbol { get; set; }
        public string Time_in_force { get; set; }
        public decimal TrailValue { get; set; }
        public decimal TriggerPrice { get; set; }
        public string TxType { get; set; }
        public string Type { get; set; }
    }
}

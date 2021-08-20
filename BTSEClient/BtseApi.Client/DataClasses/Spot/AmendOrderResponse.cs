using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class AmendOrderResponse
    {
        public string AverageFillPrice { get; set; }
        public string ClOrderID { get; set; }
        public string Deviation { get; set; }
        public string FillSize { get; set; }
        public string Message { get; set; }
        public string OrderID { get; set; }
        public string OrderType { get; set; }
        public string Price { get; set; }
        public string Side { get; set; }
        public string Size { get; set; }
        public string Status { get; set; }
        public string Stealth { get; set; }
        public string StopPrice { get; set; }
        public string Symbol { get; set; }
        public string Timestamp { get; set; }
        public string Trigger { get; set; }
        public string TriggerPrice { get; set; }
    }
}

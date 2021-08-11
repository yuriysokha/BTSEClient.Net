using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class OrderResponse
    {
        public string OrderType { get; set; }
        public decimal Price { get; set; }
        public decimal Size { get; set; }
        public string Side { get; set; }
        public decimal FilledSize { get; set; }
        public decimal FillSize { get; set; }
        public decimal AverageFillPrice { get; set; }
        public decimal OrderValue { get; set; }
        public decimal PegPriceMin { get; set; }
        public decimal PegPriceMax { get; set; }
        public decimal PegPriceDeviation { get; set; }
        public decimal CancelDuration { get; set; }
        public long Timestamp { get; set; }
        public string OrderID { get; set; }
        public decimal Stealth { get; set; }
        public bool TriggerOrder { get; set; }
        public bool Triggered { get; set; }
        public decimal TriggerPrice { get; set; }
        public decimal TriggerOriginalPrice { get; set; }
        public int TriggerOrderType { get; set; }
        public decimal TriggerTrailingStopDeviation { get; set; }
        public decimal TriggerStopPrice { get; set; }
        public string Symbol { get; set; }
        public decimal TrailValue { get; set; }
        public string ClOrderID { get; set; }
        public bool ReduceOnly { get; set; }

        /// <summary>
        /// ORDER_INSERTED, ORDER_FULLY_TRANSACTED, ORDER_PARTIALLY_TRANSACTED, ORDER_CANCELLED, STATUS_INACTIVE
        /// </summary>
        public string OrderState { get; set; }

    }
}

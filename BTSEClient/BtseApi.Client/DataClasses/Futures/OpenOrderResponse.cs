using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class OpenOrderResponse
    {
        public string orderType { get; set; }
        public decimal price { get; set; }
        public decimal size { get; set; }
        public string side { get; set; }
        public decimal filledSize { get; set; }
        public decimal avgFilledPrice { get; set; }
        public decimal orderValue { get; set; }
        public decimal pegPriceMin { get; set; }
        public decimal pegPriceMax { get; set; }
        public decimal pegPriceDeviation { get; set; }
        public decimal cancelDuration { get; set; }
        public long timestamp { get; set; }
        public string orderID { get; set; }
        public decimal stealth { get; set; }
        public bool triggerOrder { get; set; }
        public bool triggered { get; set; }
        public decimal triggerPrice { get; set; }
        public decimal triggerOriginalPrice { get; set; }
        public int triggerOrderType { get; set; }
        public decimal triggerTrailingStopDeviation { get; set; }
        public decimal triggerStopPrice { get; set; }
        public string symbol { get; set; }
        public decimal trailValue { get; set; }
        public string clOrderID { get; set; }
        public bool reduceOnly { get; set; }

        /// <summary>
        /// ORDER_INSERTED, ORDER_FULLY_TRANSACTED, ORDER_PARTIALLY_TRANSACTED, ORDER_CANCELLED, STATUS_INACTIVE
        /// </summary>
        public string orderState { get; set; }

    }
}

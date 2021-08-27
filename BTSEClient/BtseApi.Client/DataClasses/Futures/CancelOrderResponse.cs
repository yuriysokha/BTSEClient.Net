using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class CancelOrderResponse
    {
        public decimal? AverageFillPrice { get; set; }

        /// <summary>
        /// User defined id for the order (maximum 64 characters)
        /// </summary>
        public string ClOrderID { get; set; }
        public decimal? Deviation { get; set; }
        public decimal? FillSize { get; set; }
        public string Message { get; set; }
        public string OrderID { get; set; }

        /// <summary>
        /// 76: limit order, 77: market order
        /// </summary>
        public int OrderType { get; set; }
        public decimal Price { get; set; }
        public string Side { get; set; }
        public decimal Size { get; set; }

        /// <summary>
        /// 2:ORDER_INSERTED = 2, 6: Order cancelled
        /// </summary>
        public int Status { get; set; }
        public decimal Stealth { get; set; }
        public string Symbol { get; set; }
        public long Timestamp { get; set; }
        public bool Trigger { get; set; }
        public decimal TriggerPrice { get; set; }
    }
}

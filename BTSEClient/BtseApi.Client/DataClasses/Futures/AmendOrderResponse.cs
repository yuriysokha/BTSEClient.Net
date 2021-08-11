using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class AmendOrderResponse
    {
        /// <summary>
        /// 2: ORDER_INSERTED = Order is inserted successfully
        /// 6: ORDER_CANCELLED = Order is cancelled successfully
        /// 4: ORDER_FULLY_TRANSACTED = Order is fully transacted
        /// 5: ORDER_PARTIALLY_TRANSACTED = Order is partially transacted
        /// 9: TRIGGER_INSERTED = Trigger Order is inserted successfully
        /// 10: TRIGGER_ACTIVATED = Trigger Order is activated successfully
        /// 28: TRANSFER_UNSUCCESSFUL = Transfer funds between spot and futures is unsuccessful
        /// 27: TRANSFER_SUCCESSFUL = Transfer funds between futures and spot is successful
        /// 1003: ORDER_LIQUIDATION = Order is undergoing liquidation
        /// 1004: ORDER_ADL = Order is undergoing ADL
        /// 64: STATUS_LIQUIDATION = Account is undergoing liquidation
        /// 12: ERROR_UPDATE_RISK_LIMIT = Error in updating risk limit
        /// 15: ORDER_REJECTED = Order is rejected
        /// 16: ORDER_NOTFOUND = Order is not found with the order ID or clOrderID provided
        /// 41: ERROR_INVALID_RISK_LIMIT = Invalid risk limit was specified
        /// 8: INSUFFICIENT_BALANCE = Insufficient balance in account
        /// 101: FUTURES_ORDER_PRICE_OUTSIDE_LIQUIDATION_PRICE = Futures order is outside of liquidation price
        /// 1: MARKET_UNAVAILABLE = Futures market is unavailable
        /// </summary>
        public int Status { get; set; }
        public string Symbol { get; set; }

        /// <summary>
        /// 76: limit order,
        /// 77: market order,
        /// 80: peg order
        /// </summary>
        public int OrderType { get; set; }
        public decimal Price { get; set; }
        public string Side { get; set; }
        public int Size { get; set; }

        /// <summary>
        /// BTSE internal Order ID
        /// </summary>
        public string OrderId { get; set; }
        public long Timestamp { get; set; }
        public decimal TriggerPrice { get; set; }
        public bool Trigger { get; set; }

        /// <summary>
        /// only in peg order
        /// </summary>
        public decimal Deviation { get; set; }
        public decimal Stealth { get; set; }
        public string Message { get; set; }

        /// <summary>
        /// Average fill price
        /// </summary>
        public decimal AvgFillPrice { get; set; }
        public decimal FillSize { get; set; }

        /// <summary>
        /// User defined id for the order (maximum 64 characters)
        /// </summary>
        public string ClOrderId { get; set; }

        /// <summary>
        /// Original size
        /// </summary>
        public decimal OriginalSize { get; set; }
    }
}

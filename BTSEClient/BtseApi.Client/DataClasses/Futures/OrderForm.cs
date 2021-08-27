using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class OrderForm
    {
        public int size { get; set; }

        public decimal? price { get; set; }

        /// <summary>
        /// BUY, SELL
        /// </summary>
        public string side { get; set; }

        /// <summary>
        /// GTC = Good Til Cancel
        /// IOC = Immediate or Cancel
        /// FIVEMIN = 5 mins
        /// HOUR = 1 hour
        /// TWELVEHOUR = 12 hours
        /// DAY = 1 day
        /// WEEK = 1 week
        /// MONTH = 1 month, default: GTC
        /// </summary>
        public string time_in_force { get; set; }

        /// <summary>
        /// LIMIT, MARKET, OCO
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// BTCPFC
        /// </summary>
        public string symbol { get; set; }

        /// <summary>
        /// LIMIT = Default
        /// STOP = Stop Loss Orders
        /// TRIGGER = Take Profit orders
        /// </summary>
        public string txType { get; set; }

        /// <summary>
        /// true, false, default: false
        /// </summary>
        public bool? postOnly { get; set; }

        /// <summary>
        /// true, false, default: false
        /// </summary>
        public bool? reduceOnly { get; set; }

        /// <summary>
        /// When using type: OCO, this parameter can not be null
        /// </summary>
        public decimal triggerPrice { get; set; }

        /// <summary>
        /// When using type: OCO, this parameter can not be null
        /// </summary>
        public decimal? stopPrice { get; set; }

        /// <summary>
        /// Trail value. buy: positive, sell: negative
        /// </summary>
        public decimal? trailValue { get; set; }

        /// <summary>
        /// User defined id for the order (maximum 64 characters)
        /// </summary>
        public string clOrderID { get; set; }

        /// <summary>
        /// If an order is a stop loss or take profit order, then this parameter determines the trigger price.
        /// Available values are:
        /// markPrice = Mark Price(Default)
        /// lastPrice = Last transacted Price
        /// </summary>
        public string trigger { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class OrderRequest
    {
        /// <summary>
        /// 	User defined id for the order (maximum 64 characters)
        /// </summary>
        public string clOrderID { get; set; }

        public decimal? deviation { get; set; }

        public bool? postOnly { get; set; }

        /// <summary>
        /// The order price.
        /// </summary>
        public decimal? price { get; set; }

        /// <summary>
        /// BUY/SELL
        /// </summary>
        public string side { get; set; }

        public decimal size { get; set; }

        public decimal? stealth { get; set; }

        /// <summary>
        /// When using type: OCO, this parameter can not be null
        /// </summary>
        public decimal? stopPrice { get; set; }

        public string symbol { get; set; }

        /// <summary>
        /// GTC, IOC, FIVEMIN, HOUR, TWELVEHOUR, DAY, WEEK, MONTH
        /// </summary>
        public string time_in_force { get; set; }

        public decimal? trailValue { get; set; }

        /// <summary>
        /// When using type: OCO, this parameter can not be null
        /// </summary>
        public decimal? triggerPrice { get; set; }

        /// <summary>
        /// LIMIT, STOP, TRIGGER
        /// </summary>
        public string txType { get; set; }

        /// <summary>
        /// LIMIT, MARKET, OCO
        /// </summary>
        public string type { get; set; }
    }
}

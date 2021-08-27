using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class PegOrderForm
    {

        public string symbol { get; set; }

        /// <summary>
        /// BUY, SELL
        /// </summary>
        public string side { get; set; }

        /// <summary>
        /// Percentage of deviation. The value is from -10~10.
        /// </summary>
        public decimal deviation { get; set; }

        /// <summary>
        /// If side is Buy, then price is max price, 
        /// if side is Sell, then price is min price
        /// </summary>
        public decimal price { get; set; }

        public int size { get; set; }

        /// <summary>
        /// Indicate the percentage of orders to display on the order book each time. 
        /// The value is from 0~100.
        /// </summary>
        public decimal stealth { get; set; }

    }
}

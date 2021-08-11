using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class AmendOrderForm
    {
        /// <summary>
        /// PRICE - Amend Price
        /// SIZE - Amend Size
        /// TRIGGER - Amend Trigger Price
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// BTSE Internal Order ID
        /// </summary>
        public string OrderId { get; set; }
        public string Symbol { get; set; }

        /// <summary>
        /// True - Sets the price to the best bid/ask (for Post-Only orders)
        /// </summary>
        public bool Slide { get; set; }

        /// <summary>
        /// Placeholder to set value based on the type selected. 
        /// (eg. if type is PRICE, then value input would amend price)
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Client order ID
        /// </summary>
        public string ClOrderId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class AmendOrderRequest
    {
        /// <summary>
        /// PRICE - Amend Price
        /// SIZE - Amend Size
        /// TRIGGER - Amend Trigger Price
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// BTSE Internal Order ID
        /// </summary>
        public string orderID { get; set; }

        /// <summary>
        /// Symbol
        /// </summary>
        public string symbol { get; set; }

        /// <summary>
        /// True - Sets the price to the best bid/ask (for Post-Only orders)
        /// </summary>
        public bool slide { get; set; }

        /// <summary>
        /// Placeholder to set value based on the type selected. 
        /// (eg. if type is PRICE, then value input would amend price)
        /// </summary>
        public decimal value { get; set; }

        /// <summary>
        /// Client order ID
        /// </summary>
        public string clOrderID { get; set; }
    }
}

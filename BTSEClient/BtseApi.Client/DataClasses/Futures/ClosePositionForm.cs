using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class ClosePositionForm
    {
        /// <summary>
        /// LIMIT/MARKET
        /// </summary>
        public string type { get; set; }
        
        public string symbol { get; set; }

        /// <summary>
        /// Mandatory whhen type = LIMIT
        /// </summary>
        public decimal? price { get; set; }
    }
}

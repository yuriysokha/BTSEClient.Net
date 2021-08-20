using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class FiatMdl
    {
        /// <summary>
        /// Available balance
        /// </summary>
        public decimal Available { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Total balance
        /// </summary>
        public decimal Total { get; set; }
    }
}

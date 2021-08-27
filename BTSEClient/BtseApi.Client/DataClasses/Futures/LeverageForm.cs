using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class LeverageForm
    {
        public string symbol { get; set; }

        /// <summary>
        /// 0: CROSS wallet
        /// </summary>
        public decimal leverage { get; set; }
    }
}

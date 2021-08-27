using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class RiskLimitForm
    {
        public string symbol { get; set; }

        /// <summary>
        /// watch market_info api
        /// </summary>
        public int riskLimit { get; set; }
    }
}

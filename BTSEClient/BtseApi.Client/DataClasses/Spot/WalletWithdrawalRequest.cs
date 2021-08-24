using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class WalletWithdrawalRequest
    {
        /// <summary>
        /// Currency
        /// https://www.btse.com/apiexplorer/spot/#currencies
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Address to withdraw to
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Optional parameter for some coin (eg. XRP)
        /// </summary>
        public string tag { get; set; }

        /// <summary>
        /// Amount to withdraw
        /// </summary>
        public decimal amount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class WalletHistoryResponse
    {
        public string Username { get; set; }
        public string OrderId { get; set; }

        /// <summary>
        /// Wallet information
        /// CROSS@ = Cross wallet,
        /// ISOLATED@-USD = Isolated wallet
        /// SPOT@ = Spot Wallet
        /// </summary>
        public string Wallet { get; set; }
        public string Currency { get; set; }

        /// <summary>
        /// 105: Wallet Transfer
        /// 106: Wallet Liquidation
        /// 108: Realized PnL
        /// 110: Funding
        /// 121: Asset Conversion
        /// </summary>
        public int Type { get; set; }
        public decimal Amount { get; set; }
        public decimal Fees { get; set; }
        public string Description { get; set; }
        public long Timestamp { get; set; }
    }
}

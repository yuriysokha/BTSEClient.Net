using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class WalletTransferForm
    {
        /// <summary>
        /// when walletSrcType != CROSS and SPOT
        /// </summary>
        public string walletSrc { get; set; }

        /// <summary>
        /// transfer from. eg: SPOT, CROSS, ISOLATED
        /// </summary>
        public string walletSrcType { get; set; }

        /// <summary>
        /// when walletDestType != CROSS and SPOT
        /// </summary>
        public string walletDest { get; set; }

        /// <summary>
        /// transfer to. eg: SPOT, CROSS, ISOLATED
        /// </summary>
        public string walletDestType { get; set; }

        /// <summary>
        /// transfer to. eg: SPOT, CROSS, ISOLATED
        /// </summary>
        public List<ApiWallet> apiWallets { get; set; }
    }
}

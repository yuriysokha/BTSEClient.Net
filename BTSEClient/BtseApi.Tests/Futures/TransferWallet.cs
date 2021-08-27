using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class TransferWalletTests
    {
        [Test]
        public void TransferWalletObj()
        {
            var info = new WalletTransferForm();
            info.walletSrcType = "SPOT";
            info.walletDestType = "CROSS";
            info.apiWallets = new System.Collections.Generic.List<ApiWallet>();

            info.apiWallets.Add(new ApiWallet { currency = "USD", allBalance = true });
            info.apiWallets.Add(new ApiWallet { currency = "BTC", allBalance = true });

            var result = 
                Client.Operations.Futures.Transfer.
                TransferWallet.ExecuteObj(info);
        }
    }
}

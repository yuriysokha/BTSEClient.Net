using System;
using BtseApi.Client.DataClasses.Spot;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class WalletWithdrawalTests
    {

        [Test]
        public void WalletWithdrawalObj()
        {
            var info = new WalletWithdrawalRequest();
            info.address = "tb1quruu82xdf4rd5f7c8rj30ppve3jsnzp9u3fune";
            info.currency = "BTC";
            info.amount = 0.001m;

            var result = Client.Operations.Spot.Wallet.WalletWithdrawal.ExecuteObj(info);
            TestContext.WriteLine(result);
        }
    }
}

using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class WalletTests
    {
        [Test]
        public void Wallet()
        {
            var result = Client.Operations.Futures.Read.Wallet.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void WalletObj()
        {
            var result = Client.Operations.Futures.Read.Wallet.ExecuteObj();
        }
    }
}

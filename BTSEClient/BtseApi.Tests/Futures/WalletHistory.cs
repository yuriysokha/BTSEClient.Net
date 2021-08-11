using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class WalletHistoryTests
    {
        [Test]
        public void Wallet()
        {
            var result = Client.Operations.Futures.Read.WalletHistory.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void WalletObj()
        {
            var result = Client.Operations.Futures.Read.WalletHistory.ExecuteObj();

            TestContext.WriteLine(result.ToString());
        }
    }
}

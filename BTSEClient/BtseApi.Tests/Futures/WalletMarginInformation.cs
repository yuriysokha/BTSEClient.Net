using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class WalletMarginInformationTests
    {
        [Test]
        public void WalletMarginInformation()
        {
            var result = Client.Operations.Futures.Read.WalletMarginInformation.Execute("BTCPFC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void WalletMarginInformationObj()
        {
            var result = Client.Operations.Futures.Read.WalletMarginInformation.ExecuteObj("BTCPFC");
        }
    }
}

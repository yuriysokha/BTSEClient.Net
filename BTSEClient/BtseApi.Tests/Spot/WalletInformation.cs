using System;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class WalletInformationTests
    {
        [Test]
        public void WalletInformation()
        {
            var result = Client.Operations.Spot.Read.WalletInformation.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void WalletInformationObj()
        {
            var result = Client.Operations.Spot.Read.WalletInformation.ExecuteObj();
        }
    }
}

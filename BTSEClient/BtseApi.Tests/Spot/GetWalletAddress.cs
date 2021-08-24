using System;
using BtseApi.Client.DataClasses.Spot;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class GetWalletAddressTests
    {
        [Test]
        public void GetWalletAddress()
        {
            var result = Client.Operations.Spot.Wallet.GetWalletAddress.Execute("BTC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetWalletAddressObj()
        {
            var result = Client.Operations.Spot.Wallet.GetWalletAddress.ExecuteObj("BTC");
            TestContext.WriteLine(result);
        }
    }
}

using System;
using BtseApi.Client.DataClasses.Spot;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class CreateWalletAddressTests
    {
        [Test]
        public void CreateWalletAddress()
        {
            var result = Client.Operations.Spot.Wallet.CreateWalletAddress.Execute("BTC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void CreateWalletAddressObj()
        {
            var result = Client.Operations.Spot.Wallet.CreateWalletAddress.ExecuteObj("BTC");
            TestContext.WriteLine(result);
        }
    }
}

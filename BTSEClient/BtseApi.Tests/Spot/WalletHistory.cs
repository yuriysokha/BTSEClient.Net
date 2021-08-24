using System;
using BtseApi.Client.DataClasses.Spot;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class WalletHistoryTests
    {
        [Test]
        public void WalletHistory()
        {
            var result = Client.Operations.Spot.Read.WalletHistory.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void WalletHistoryObj()
        {
            var result = Client.Operations.Spot.Read.WalletHistory.ExecuteObj();
            TestContext.WriteLine(result);
        }
    }
}

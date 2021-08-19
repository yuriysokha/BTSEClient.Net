using System;
using BtseApi.Client.DataClasses.Spot;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class TradeHistoryTests
    {
        [Test]
        public void TradeHistory()
        {
            var result = Client.Operations.Spot.Read.TradeHistory.Execute("BTC-USD");
            TestContext.WriteLine(result);
        }

        [Test]
        public void TradeHistoryObj()
        {
            var result = Client.Operations.Spot.Read.TradeHistory.ExecuteObj("BTC-USD");
            TestContext.WriteLine(result);
        }
    }
}

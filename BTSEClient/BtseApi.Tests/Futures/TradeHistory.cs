using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class TradeHistoryTests
    {
        [Test]
        public void TradeHistory()
        {
            var result = Client.Operations.Futures.PublicEndpoints.TradeHistory.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void TradeHistoryObj()
        {
            var result = Client.Operations.Futures.PublicEndpoints.TradeHistory.ExecuteObj();
        }
    }
}

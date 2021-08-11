using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class FeesTests
    {
        [Test]
        public void Fees()
        {
            var result = Client.Operations.Futures.PublicEndpoints.TradeHistory.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void FeesObj()
        {
            var result = Client.Operations.Futures.Read.Fees.ExecuteObj();
        }
    }
}

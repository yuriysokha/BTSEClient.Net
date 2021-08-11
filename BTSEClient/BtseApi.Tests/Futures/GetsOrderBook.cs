using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class GetsOrderBookTests
    {
        [Test]
        public void GetsOrderBook()
        {
            var result = Client.Operations.Futures.PublicEndpoints.GetsOrderBook.Execute("ETHPFC", 10);
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetsOrderBookZeroDepth()
        {
            var result = Client.Operations.Futures.PublicEndpoints.GetsOrderBook.Execute("ETHPFC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetsOrderBookObj()
        {
            var result = Client.Operations.Futures.PublicEndpoints.GetsOrderBook.ExecuteObj("ETHPFC", 10);
        }
    }
}

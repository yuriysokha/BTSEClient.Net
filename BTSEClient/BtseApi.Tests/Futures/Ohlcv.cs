using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class OhlcvTests
    {
        [Test]
        public void GetsOhlcv()
        {
            var result = Client.Operations.Futures.PublicEndpoints.Ohlcv.Execute("BTCPFC", 30);
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetsOhlcvObj()
        {
            var result = Client.Operations.Futures.PublicEndpoints.Ohlcv.ExecuteObj("BTCPFC", 30);
        }
    }
}

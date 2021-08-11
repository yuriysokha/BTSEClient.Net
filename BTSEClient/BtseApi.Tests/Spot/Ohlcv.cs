using System;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class OhlcvTests
    {
        [Test]
        public void GetsOhlcv()
        {
            var result = Client.Operations.Spot.PublicEndpoints.Ohlcv.Execute("BTC-USD", 30);
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetsOhlcvObj()
        {
            var result = Client.Operations.Spot.PublicEndpoints.Ohlcv.ExecuteObj("BTC-USD", 30);
        }
    }
}

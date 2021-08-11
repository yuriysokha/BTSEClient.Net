using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class PriceIndexTests
    {
        [Test]
        public void PriceIndex()
        {
            var result = Client.Operations.Futures.PublicEndpoints.PriceIndex.Execute("BTCPFC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void PriceIndexObj()
        {
            //var result = Client.Operations.PublicEndpoints.PriceIndex.ExecuteObj("BTCPFC");

            var result = Client.Operations.Futures.PublicEndpoints.PriceIndex.ExecuteObj();
        }
    }
}

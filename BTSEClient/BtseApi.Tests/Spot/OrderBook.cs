using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class OrderBook
    {
        [Test]
        public void GetOrderBook()
        {
            var result = Client.Operations.Spot.PublicEndpoints.GetsOrderBook.Execute("BTC-USD");
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetOrderBookObj()
        {
            var result = Client.Operations.Spot.PublicEndpoints.GetsOrderBook.ExecuteObj("BTC-USD");
            //var result = Client.Operations.Spot.PublicEndpoints.MarketSummary.ExecuteObj();
        }
    }
}

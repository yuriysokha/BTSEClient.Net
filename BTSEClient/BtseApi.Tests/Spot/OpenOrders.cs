using System;
using BtseApi.Client.DataClasses.Spot;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class OpenOrders
    {
        [Test]
        public void PlaceOrderObj()
        {
            var result = Client.Operations.Spot.Read.OpenOrders.Execute("BTC-USD");
            TestContext.WriteLine(result);
        }


        [Test]
        public void PlaceOrderMarketBitkoinSellObj()
        {
            var result = Client.Operations.Spot.Read.OpenOrders.ExecuteObj("BTC-USD");
        }
    }
}

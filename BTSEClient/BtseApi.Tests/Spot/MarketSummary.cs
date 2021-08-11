using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class MarketSummary
    {
        [Test]
        public void GetHighLevelMarketOverview()
        {
            var result = Client.Operations.Spot.PublicEndpoints.MarketSummary.Execute("ETHPFC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetHighLevelMarketOverviewBTCPFC()
        {
            var result = Client.Operations.Spot.PublicEndpoints.MarketSummary.Execute("BTCPFC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetHighLevelMarketOverviewObj()
        {
            var result = Client.Operations.Spot.PublicEndpoints.MarketSummary.ExecuteObj("BTC-USD");
            //var result = Client.Operations.Spot.PublicEndpoints.MarketSummary.ExecuteObj();
        }
    }
}

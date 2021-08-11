using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class MarketSummary
    {
        [Test]
        public void GetHighLevelMarketOverview()
        {
            var result = Client.Operations.Futures.PublicEndpoints.HighLevelMarketOverview.Execute("ETHPFC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetHighLevelMarketOverviewBTCPFC()
        {
            var result = Client.Operations.Futures.PublicEndpoints.HighLevelMarketOverview.Execute("BTCPFC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetHighLevelMarketOverviewObj()
        {
            // var result = Client.Operations.PublicEndpoints.HighLevelMarketOverview.ExecuteObj("ETHPFC");
            var result = Client.Operations.Futures.PublicEndpoints.HighLevelMarketOverview.ExecuteObj();
        }
    }
}

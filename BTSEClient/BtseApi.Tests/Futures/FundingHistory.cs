using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class FundingHistoryTests
    {
        [Test]
        public void GetFundingHistory()
        {
            var result = Client.Operations.Futures.PublicEndpoints.FundingHistory.Execute("BTCPFC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void GetFundingHistoryETHPFC()
        {
            var result = Client.Operations.Futures.PublicEndpoints.FundingHistory.Execute("ETHPFC");
        }

        [Test]
        public void GetFundingHistoryObjETHPFC()
        {
            var result = Client.Operations.Futures.PublicEndpoints.FundingHistory.ExecuteObj("ETHPFC");
        }
    }
}

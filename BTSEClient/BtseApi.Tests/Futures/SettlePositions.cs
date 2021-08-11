using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class SettlePositionTests
    {
        [Test]
        public void SettlePosition()
        {
            var result = Client.Operations.Futures.Read.SettlePositions.Execute("BTCPFC", "BTC");
            TestContext.WriteLine(result);
        }

        [Test]
        public void SettlePositionObj()
        {
            var result = Client.Operations.Futures.Read.SettlePositions.ExecuteObj("BTCPFC", "BTC");
        }
    }
}

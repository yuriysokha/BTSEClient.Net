using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class IndexPegOrderTests
    {
        [Test]
        public void IndexPegOrderObj()
        {
            var info = new PegOrderForm();
            info.symbol = "BTCPFC";
            info.side = "BUY";
            info.deviation = 10;
            info.price = 10;
            info.size = 1;
            info.stealth = 0;

            var result = Client.Operations.Futures.Trading.IndexOrderPegOrder.ExecuteObj(info);
        }
    }
}

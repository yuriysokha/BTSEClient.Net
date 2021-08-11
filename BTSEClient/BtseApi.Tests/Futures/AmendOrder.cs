using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class AmendOrderTests
    {
        [Test]
        public void AmendOrder()
        {
            var info = new AmendOrderForm();
            info.Symbol = "BTCPFC";
            info.Slide = true;

            var result = Client.Operations.Futures.Trading.AmendOrder.Execute(info);
            TestContext.WriteLine(result);
        }

        [Test]
        public void AmendOrderObj()
        {
            var info = new AmendOrderForm();
            info.Symbol = "BTCPFC";
            info.Slide = true;

            var result = Client.Operations.Futures.Trading.AmendOrder.ExecuteObj(info);
        }
    }
}

using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class SettleInTests
    {
        [Test]
        public void SettleInObj()
        {
            var info = new SettleInForm();
            info.Symbol = "BTCPFC";
            info.Currency = "BTC";

            var result = 
                Client.Operations.Futures.Trading.
                SettleIn.Execute(info);
        }
    }
}

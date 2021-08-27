using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class SetLeverageTests
    {
        [Test]
        public void SetLeverageObj()
        {
            var info = new LeverageForm();
            info.symbol = "BTCPFC";
            info.leverage = 20.5m;

            var result = 
                Client.Operations.Futures.Trading.
                SetLeverage.ExecuteObj(info);
        }
    }
}

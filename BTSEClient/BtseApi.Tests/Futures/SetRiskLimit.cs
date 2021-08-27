using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class SetRiskLimitTests
    {
        [Test]
        public void SetRiskLimitObj()
        {
            var info = new RiskLimitForm();
            info.symbol = "BTCPFC";
            info.riskLimit = 200000;

            var result = 
                Client.Operations.Futures.Trading.
                SetRiskLimit.ExecuteObj(info);
        }
    }
}

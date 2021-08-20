using System;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class FeesTests
    {
        [Test]
        public void Fees()
        {
            var result = Client.Operations.Spot.Read.FeeInformation.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void FeesObj()
        {
            var result = Client.Operations.Spot.Read.FeeInformation.ExecuteObj();
        }
    }
}

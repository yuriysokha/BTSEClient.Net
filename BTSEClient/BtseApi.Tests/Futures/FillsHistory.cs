using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class FillsHistoryTests
    {
        [Test]
        public void FillsHistory()
        {
            var result = Client.Operations.Futures.Read.FillsHistory.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void FillsHistoryObj()
        {
            var result = Client.Operations.Futures.Read.FillsHistory.ExecuteObj();
        }
    }
}

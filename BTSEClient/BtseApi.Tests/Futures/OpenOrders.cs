using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class OpenOrdersTests
    {
        [Test]
        public void OpenOrders()
        {
            var result = Client.Operations.Futures.Read.OpenOrders.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void OpenOrdersObj()
        {
            var result = Client.Operations.Futures.Read.OpenOrders.ExecuteObj();
        }
    }
}

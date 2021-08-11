using System;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class PositionTests
    {
        [Test]
        public void Position()
        {
            var result = Client.Operations.Futures.Read.Position.Execute();
            TestContext.WriteLine(result);
        }

        [Test]
        public void PositionObj()
        {
            var result = Client.Operations.Futures.Read.Position.ExecuteObj();
        }
    }
}

using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class CancelAllAfterTests
    {
        [Test]
        public void CancelAllAfter()
        {
            var info = new CancelAllAfterRequest();
            info.timeout = 10000;

            var cancelAllAfterResult = 
                Client.Operations.Futures.Trading.
                CancelAllAfter.Execute(info);
        }
    }
}

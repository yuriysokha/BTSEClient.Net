using System;
using BtseApi.Client.DataClasses.Spot;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
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
                Client.Operations.Spot.Trading.
                CancelAllAfter.Execute(info);
        }
    }
}

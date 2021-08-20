using System;
using BtseApi.Client.DataClasses.Spot;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class CancelOrderTests
    {
        [Test]
        public void CancelOrderObj()
        {
            // first: place new limit order

            var info = new OrderRequest();

            info.clOrderID = Guid.NewGuid().ToString();
            info.deviation = 0;
            info.postOnly = false;
            info.price = 41000;
            info.side = "BUY";
            info.size = 0.03m;
            info.stealth = 0;
            info.stopPrice = 0;
            info.symbol = "BTC-USD";
            info.time_in_force = "GTC";
            info.trailValue = 0;
            info.triggerPrice = 0;
            info.txType = "LIMIT";
            info.type = "LIMIT"; //"LIMIT";

            var result = Client.Operations.Spot.Trading.Order.ExecuteObj(info);

            var cancelResult = 
                Client.Operations.Spot.Trading.
                CancelOrder.ExecuteObj("BTC-USD", result[0].OrderId);
        }
    }
}

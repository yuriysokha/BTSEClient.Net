using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class CancelOrderTests
    {
        [Test]
        public void CancelOrderObj()
        {
            // first: place new limit order

            var info = new OrderForm();

            info.clOrderID = Guid.NewGuid().ToString();
            info.postOnly = false;
            info.price = 41000;
            info.side = "BUY";
            info.size = 1;
            info.stopPrice = 0;
            info.symbol = "BTCPFC";
            info.time_in_force = "GTC";
            info.trailValue = 0;
            info.triggerPrice = 0;
            info.txType = "LIMIT";
            info.type = "LIMIT"; //"LIMIT";

            var result = Client.Operations.Futures.Trading.LimitMarketOrder.ExecuteObj(info);

            var cancelResult = 
                Client.Operations.Spot.Trading.
                CancelOrder.ExecuteObj("BTC-USD", result[0].orderID);
        }

        [Test]
        public void CancelAll()
        {
             var cancelResult =
                Client.Operations.Spot.Trading.
                CancelOrder.ExecuteObj("BTCPFC");
        }
    }
}

using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class AmendOrderTests
    {
        [Test]
        public void AmendOrderObj()
        {
            var info = new OrderForm();
            info.size = 1;
            info.price = 8m;

            info.side = "BUY";

            info.symbol = "BTCPFC";

            info.time_in_force = "GTC";

            info.type = "LIMIT";

            info.postOnly = false;
            info.reduceOnly = false;
            info.triggerPrice = 0;
            info.stopPrice = 0;
            info.trailValue = 5;
            //info.clOrderID = "market001";


            var createResult = Client.Operations.Futures.Trading.LimitMarketOrder.ExecuteObj(info);

            var amendInfo = new AmendOrderForm();
            //amendInfo.Symbol = "BTCPFC";
            amendInfo.Type = "SIZE";
            amendInfo.OrderId = createResult[0].orderID;
            amendInfo.Value = 2m;
            amendInfo.Slide = true;

            var result = Client.Operations.Futures.Trading.AmendOrder.ExecuteObj(amendInfo);
        }
    }
}

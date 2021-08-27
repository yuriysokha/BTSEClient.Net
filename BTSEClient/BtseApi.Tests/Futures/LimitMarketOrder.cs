using System;
using BtseApi.Client.DataClasses.Futures;
using NUnit.Framework;

namespace BtseApi.Tests.Futures
{
    [TestFixture]
    public class LimitMarketOrderTests
    {
        [Test]
        public void LimitMarketOrderObj()
        {
            var info = new OrderForm();
            info.size = 1;
            info.price = 0.5m;

            info.side = "BUY";

            info.symbol = "BTCPFC";

            info.time_in_force = "GTC";
            
            info.type = "LIMIT";

            info.postOnly = false;
            info.reduceOnly = false;
            info.triggerPrice = 0;
            info.stopPrice = 0;
            info.trailValue = 5;
            info.clOrderID = "market001";


            var result = Client.Operations.Futures.Trading.LimitMarketOrder.ExecuteObj(info);
        }
    }
}

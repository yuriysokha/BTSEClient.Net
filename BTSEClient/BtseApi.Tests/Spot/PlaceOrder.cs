using System;
using BtseApi.Client.DataClasses.Spot;
using NUnit.Framework;

namespace BtseApi.Tests.Spot
{
    [TestFixture]
    public class PlaceOrderTests
    {
        [Test]
        public void PlaceOrderObj()
        {
            var info = new OrderRequest();
            info.clOrderID = Guid.NewGuid().ToString();
            info.deviation = 0;
            info.postOnly = false;
            info.price = 40000;
            info.side = "BUY";
            info.size = 0.01m;
            info.stealth = 0;
            info.stopPrice = 0;
            info.symbol = "BTC-USD";
            info.time_in_force = "GTC";
            info.trailValue = 0;
            info.triggerPrice = 0;
            info.txType = "LIMIT";
            info.type = "LIMIT"; //"LIMIT";

            var result = Client.Operations.Spot.Trading.Order.ExecuteObj(info);
        }


        [Test]
        public void PlaceOrderMarketBitkoinSellObj()
        {
            var info = new OrderRequest();
            info.side = "SELL";
            info.size = 0.002m;
            info.symbol = "BTC-USD";
            info.txType = "LIMIT";
            info.type = "MARKET"; //"LIMIT";

            var result = Client.Operations.Spot.Trading.Order.ExecuteObj(info);
        }


        [Test]
        public void TestBuyDollars()
        {
            decimal amountinDollars = 17;

            var marketInfo = Client.Operations.Spot.PublicEndpoints.
                MarketSummary.ExecuteObj("BTC-USD");

            var amountInBtc = amountinDollars / marketInfo[0].Last;

            var roundUpAmount = Math.Truncate(amountInBtc * 100000) / 100000 + 0.00001m;

            var info = new OrderRequest();
            info.side = "SELL";
            info.size = roundUpAmount;
            info.symbol = "BTC-USD";
            info.txType = "LIMIT";
            info.type = "MARKET"; //"LIMIT";

            var result = Client.Operations.Spot.Trading.Order.ExecuteObj(info);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class OrderBookResponse
    {
        public string Symbol { get; set; }
        public decimal Gain { get; set; }

        public long Timestamp { get; set; }

        public List<Qoute> BuyQuote { get; set; }

        public List<Qoute> SellQuote { get; set; }
    }

    public class Qoute
    {
        public string Price { get; set; }
        public string Size { get; set; }
    }
}

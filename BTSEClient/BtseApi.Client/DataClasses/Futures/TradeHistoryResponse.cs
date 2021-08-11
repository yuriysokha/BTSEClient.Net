using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class TradeHistoryResponse
    {
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string Side { get; set; }
        public string Symbol { get; set; }

        public long SerialId { get; set; }

        public long Timestamp { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class WalletHistoryResponse
    {
        public decimal amount { get; set; }
        public string currency { get; set; }
        public string description { get; set; }
        public decimal fees { get; set; }
        public long orderId { get; set; }
        public int status { get; set; }
        public long timestamp { get; set; }
        public int type { get; set; }
        public string username { get; set; }
        public string wallet { get; set; }
        public string txid { get; set; }
        public string currencyNetwork { get; set; }
    }
}

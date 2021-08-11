using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class FundingHistoryResponse
    {
        public long Time { get; set; }
        public decimal Rate { get; set; }
        public string Symbol { get; set; }
    }
}

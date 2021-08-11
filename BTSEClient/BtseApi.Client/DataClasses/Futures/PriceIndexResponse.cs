using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class PriceIndexResponse
    {
        public string Symbol { get; set; }
        public decimal IndexPrice { get; set; }
        public decimal LastPrice { get; set; }
        public decimal MarkPrice { get; set; }
    }
}

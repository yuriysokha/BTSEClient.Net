using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class FeesResponse
    {
        public string Symbol { get; set; }
        public decimal MakerFee { get; set; }
        public decimal TakerFee { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtseApi.Client.DataClasses.Futures
{
    public class SimpleResponse
    {
        public string Symbol { get; set; }

        public long Timestamp { get; set; }

        public int Status { get; set; }

        public int Type { get; set; }

        public string Message { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class SettleInResponse
    {
        public string Status { get; set; }
        public string ErrorCode { get; set; }

        public string Message { get; set; }
    }
}

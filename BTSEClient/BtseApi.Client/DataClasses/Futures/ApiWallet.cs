using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtseApi.Client.DataClasses.Futures
{
    public class ApiWallet
    {
        public string currency { get; set; }
        public decimal balance { get; set; }
        public bool allBalance { get; set; }
    }
}

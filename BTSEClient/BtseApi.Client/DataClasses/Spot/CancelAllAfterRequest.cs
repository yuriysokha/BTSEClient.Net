using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Spot
{
    public class CancelAllAfterRequest
    {
        /// <summary>
        /// Timeout in ms.
        /// </summary>
        public long timeout { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

using System.Collections.Generic;
using System.Text.Json;
using BtseApi.Client.Helpers;
using BtseApi.Client.DataClasses.Futures;

namespace BtseApi.Client.Operations.Futures.PublicEndpoints
{
    /// <summary>
    /// Provides funding rate history. Dataset included is only for the past 30 days.
    /// </summary>
    public static class FundingHistory
    {
        private static string url = "/api/v2.1/funding_history";

        /// <summary>
        /// Provides funding rate history. Dataset included is only for the past 30 days.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns>Provides funding rate history. Dataset included is only for the past 30 days.</returns>
        public static string Execute(string symbol = null)
        {
            var client = Helper.GetClient(url);

            var request = new RestRequest(Method.GET);

            if (symbol != null)
            {
                request.AddParameter("symbol", symbol, ParameterType.QueryString);
            }

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Provides funding rate history. Dataset included is only for the past 30 days.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns>Provides funding rate history. Dataset included is only for the past 30 days.</returns>
        public static dynamic ExecuteObj(string symbol)
        {
            var json = Execute(symbol);

            var result =
               JsonSerializer.Deserialize<Dictionary<string, List<FundingHistoryResponse>>>(json,
               new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

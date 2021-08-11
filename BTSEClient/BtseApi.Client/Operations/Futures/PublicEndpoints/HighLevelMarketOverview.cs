using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using RestSharp;

using BtseApi.Client.DataClasses.Futures;
using BtseApi.Client.Helpers;

namespace BtseApi.Client.Operations.Futures.PublicEndpoints
{
    public static class HighLevelMarketOverview
    {
        private static string url = "/api/v2.1/market_summary";

        /// <summary>
        /// This API provides a high level overview of the market. 
        /// Provides you with information such as the best bid/ask, 
        /// price movements over the last day and volume information.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns></returns>
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
        /// This API provides a high level overview of the market. 
        /// Provides you with information such as the best bid/ask, 
        /// price movements over the last day and volume information.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns></returns>
        public static List<MarketSummaryResponse> ExecuteObj(string symbol = null)
        {
            var json = Execute(symbol);

            var result =
               JsonSerializer.Deserialize<List<MarketSummaryResponse>>(json,
               new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

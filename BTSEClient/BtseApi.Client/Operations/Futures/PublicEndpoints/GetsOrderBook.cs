using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Text.Json;
using BtseApi.Client.DataClasses.Futures;
using BtseApi.Client.Helpers;

namespace BtseApi.Client.Operations.Futures.PublicEndpoints
{
    public static class GetsOrderBook
    {
        private static string url = "/api/v2.1/orderbook/L2";

        /// <summary>
        /// Gets level 2 Orderbook for a given symbol
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <param name="depth">OrderBook depth. Eg. 10 would return 10 levels of bid and ask on the orderbook</param>
        /// <returns>Gets level 2 Orderbook for a given symbol</returns>
        public static string Execute(string symbol, int? depth = null)
        {
            var client = Helper.GetClient(url);

            var request = new RestRequest(Method.GET);

            request.AddParameter("symbol", symbol, ParameterType.QueryString);

            if(depth.HasValue)
            {
                request.AddParameter("depth", depth, ParameterType.QueryString);
            }

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Gets level 2 Orderbook for a given symbol
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <param name="depth">OrderBook depth. Eg. 10 would return 10 levels of bid and ask on the orderbook</param>
        /// <returns>Gets level 2 Orderbook for a given symbol</returns>
        public static OrderBookResponse ExecuteObj(string symbol, int? depth = null)
        {
            var json = Execute(symbol, depth);

            var result =
               JsonSerializer.Deserialize<OrderBookResponse> (json,
               new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

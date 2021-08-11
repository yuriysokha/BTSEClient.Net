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
    public static class PriceIndex
    {
        private static string url = "/api/v2.1/price";

        /// <summary>
        /// This API returns market index price, last price and mark price
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns>This API returns market index price, last price and mark price</returns>
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
        /// This API returns market index price, last price and mark price
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns>This API returns market index price, last price and mark price</returns>
        public static List<PriceIndexResponse> ExecuteObj(string symbol = null)
        {
            var json = Execute(symbol);

            var result =
               JsonSerializer.Deserialize<List<PriceIndexResponse>>(json,
               new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using RestSharp;

using BtseApi.Client.DataClasses.Futures;
using BtseApi.Client.ApiSettings;
using BtseApi.Client.Helpers;

namespace BtseApi.Client.Operations.Futures.Read
{
    public static class Fees
    {
        private static string urlPath = "/api/v2.1/user/fees";

        /// <summary>
        /// Query returns a user's fees for the market.
        /// If no symbol is specified, then fees for all futures markets will be returned.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns>Query returns a user's fees for the market.
        /// If no symbol is specified, then fees for all futures markets will be returned.</returns>
        public static string Execute(string symbol = null)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.GET);
            Helper.AddRequestAuth(request, urlPath, string.Empty);

            if (symbol != null)
            {
                request.AddParameter("symbol", symbol, ParameterType.QueryString);
            }

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Query returns a user's fees for the market.
        /// If no symbol is specified, then fees for all futures markets will be returned.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns>Query returns a user's fees for the market.
        /// If no symbol is specified, then fees for all futures markets will be returned.</returns>
        public static List<FeesResponse> ExecuteObj(string symbol = null)
        {
            var json = Execute(symbol);

            var result =
                JsonSerializer.Deserialize<List<FeesResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

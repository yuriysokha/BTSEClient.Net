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
    public static class Position
    {
        private static string urlPath = "/api/v2.1/user/positions";

        /// <summary>
        /// Queries user's current position.
        /// When no symbol is specified, positions for all markets are returned.
        /// </summary>
        /// <param name="symbol">symbol (eg. BTCPFC, BTCZ19)</param>
        /// <returns>Queries user's current position.</returns>
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
        /// Queries user's current position.
        /// When no symbol is specified, positions for all markets are returned.
        /// </summary>
        /// <param name="symbol">symbol (eg. BTCPFC, BTCZ19)</param>
        /// <returns>Queries user's current position.</returns>
        public static List<PositionResponse> ExecuteObj(string symbol = null)
        {
            var json = Execute(symbol);

            var result =
                JsonSerializer.Deserialize<List<PositionResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

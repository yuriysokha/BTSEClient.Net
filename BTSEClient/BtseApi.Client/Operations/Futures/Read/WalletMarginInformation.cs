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
    public static class WalletMarginInformation
    {
        private static string urlPath = "/api/v2.1/user/margin";

        /// <summary>
        /// Gets margin information for the specified wallet so that users can know which wallet they are currently using in the market.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns>Gets margin information for the specified wallet so that users can know which wallet they are currently using in the market.</returns>
        public static string Execute(string symbol)
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
        /// Gets margin information for the specified wallet so that users can know which wallet they are currently using in the market.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC)</param>
        /// <returns>Gets margin information for the specified wallet so that users can know which wallet they are currently using in the market.</returns>
        public static WalletMarginInformationResponse ExecuteObj(string symbol)
        {
            var json = Execute(symbol);

            var result =
                JsonSerializer.Deserialize<WalletMarginInformationResponse>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

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
    public class Wallet
    {
        private static string urlPath = "/api/v2.1/user/wallet";

        /// <summary>
        /// Returns user's wallet information
        /// </summary>
        /// <param name="wallet">Wallet name (eg. CROSS@, ISOLATED@BTCPFC-USD)</param>
        /// <returns>Returns user's wallet information</returns>
        public static string Execute(string wallet = null)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.GET);

            if (wallet != null)
            {
                request.AddParameter("wallet", wallet, ParameterType.QueryString);
            }

            Helper.AddRequestAuth(request, urlPath, string.Empty);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Returns user's wallet information
        /// </summary>
        /// <param name="wallet">Wallet name (eg. CROSS@, ISOLATED@BTCPFC-USD)</param>
        /// <returns>Returns user's wallet information</returns>
        public static List<WalletResponse> ExecuteObj(string wallet = null)
        {
            var json = Execute(wallet);

            var result =
                JsonSerializer.Deserialize<List<WalletResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

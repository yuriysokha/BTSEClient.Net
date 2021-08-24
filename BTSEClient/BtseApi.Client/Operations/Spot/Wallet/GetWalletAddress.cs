using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using RestSharp;

using BtseApi.Client.DataClasses.Spot;
using BtseApi.Client.ApiSettings;
using BtseApi.Client.Helpers;

namespace BtseApi.Client.Operations.Spot.Wallet
{
    public static class GetWalletAddress
    {
        private static string urlPath = "/api/v3.2/user/wallet/address";

        public static string Execute(
            string currency)
        {
            var client = Helper.GetClient(urlPath, true);

            var request = new RestRequest(Method.GET);
            Helper.AddRequestAuth(request, urlPath, string.Empty);

            request.AddParameter("currency", currency, ParameterType.QueryString);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        public static List<WalletResponse> ExecuteObj(
            string currency)
        {
            var json = Execute(currency);

            var result =
                JsonSerializer.Deserialize<List<WalletResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

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

namespace BtseApi.Client.Operations.Spot.Read
{
    public static class WalletHistory
    {
        private static string urlPath = "/api/v3.2/user/wallet_history";

        public static string Execute(
            long? startTime = null,
            long? endTime = null,
            int? count = null,
            string currency = null)
        {
            var client = Helper.GetClient(urlPath, true);

            var request = new RestRequest(Method.GET);
            Helper.AddRequestAuth(request, urlPath, string.Empty);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        public static List<WalletHistoryResponse> ExecuteObj(
            long? startTime = null,
            long? endTime = null,
            int? count = null,
            string currency = null)
        {
            var json = Execute();

            var result =
                JsonSerializer.Deserialize<List<WalletHistoryResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

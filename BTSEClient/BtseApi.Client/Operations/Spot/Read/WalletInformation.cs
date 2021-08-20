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
    public static class WalletInformation
    {
        private static string urlPath = "/api/v3.2/user/wallet";

        public static string Execute()
        {
            var client = Helper.GetClient(urlPath, true);

            var request = new RestRequest(Method.GET);
            Helper.AddRequestAuth(request, urlPath, string.Empty);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        public static List<FiatMdl> ExecuteObj()
        {
            var json = Execute();

            var result =
                JsonSerializer.Deserialize<List<FiatMdl>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

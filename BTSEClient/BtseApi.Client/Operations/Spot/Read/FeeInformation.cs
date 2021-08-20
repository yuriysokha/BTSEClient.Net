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
    public static class FeeInformation
    {
        private static string urlPath = "/api/v3.2/user/fees";

        public static string Execute(string symbol = null)
        {
            var client = Helper.GetClient(urlPath, true);

            var request = new RestRequest(Method.GET);
            Helper.AddRequestAuth(request, urlPath, string.Empty);

            if (symbol != null)
            {
                request.AddParameter("symbol", symbol, ParameterType.QueryString);
            }

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

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

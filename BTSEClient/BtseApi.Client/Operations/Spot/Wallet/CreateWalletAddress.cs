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
    public static class CreateWalletAddress
    {
        private static string urlPath = "/api/v3.2/user/wallet/address";

        public static string Execute(
            string currency)
        {
            var client = Helper.GetClient(urlPath, true);

            var request = new RestRequest(Method.POST);

            request.RequestFormat = DataFormat.Json;

            var options = new JsonSerializerOptions();
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            var info = new CreateWalletRequest();
            info.currency = currency;

            var body = JsonSerializer.Serialize(info, options);

            request.AddJsonBody(body);

            Helper.AddRequestAuth(request, urlPath, body);

            //request.AddParameter("currency", currency, ParameterType.RequestBody);

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

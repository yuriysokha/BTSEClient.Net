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

namespace BtseApi.Client.Operations.Futures.Transfer
{
    public static class TransferWallet
    {
        private static string urlPath = "/api/v2.1/user/wallet/transfer";

        /// <summary>
        /// API transfers funds between user's wallet. User can specify the source and target wallet to transfer funds
        /// </summary>
        public static string Execute(WalletTransferForm info)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;

            var options = new JsonSerializerOptions();
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            var body = JsonSerializer.Serialize(info, options);

            request.AddJsonBody(body);

            Helper.AddRequestAuth(request, urlPath, body);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// API transfers funds between user's wallet. User can specify the source and target wallet to transfer funds
        /// </summary>
        public static SimpleResponse ExecuteObj(WalletTransferForm info)
        {
            var json = Execute(info);

            var result =
                JsonSerializer.Deserialize<SimpleResponse>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

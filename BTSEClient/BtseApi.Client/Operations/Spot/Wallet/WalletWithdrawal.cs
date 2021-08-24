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
    public static class WalletWithdrawal
    {
        private static string urlPath = "/spot/api/v3.2/user/wallet/withdraw";

        public static string Execute(
            WalletWithdrawalRequest info)
        {
            var client = Helper.GetClient(urlPath, true);

            var request = new RestRequest(Method.POST);

            request.RequestFormat = DataFormat.Json;

            var options = new JsonSerializerOptions();
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            var body = JsonSerializer.Serialize(info, options);

            request.AddJsonBody(body);

            Helper.AddRequestAuth(request, urlPath, body);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        public static WalletWithdrawalResponse ExecuteObj(
            WalletWithdrawalRequest info)
        {
            var json = Execute(info);

            var result =
                JsonSerializer.Deserialize<WalletWithdrawalResponse>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

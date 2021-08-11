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

namespace BtseApi.Client.Operations.Futures.Trading
{
    public static class AmendOrder
    {
        private static string urlPath = "/api/v2.1/order";

        /// <summary>
        /// Sets the currency to settle the current position in
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="currency">Currency</param>
        /// <returns>Sets the currency to settle the current position in</returns>
        public static string Execute(AmendOrderForm info)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.PUT);
            request.RequestFormat = DataFormat.Json;

            var body = JsonSerializer.Serialize(info);

            request.AddBody(body);

            Helper.AddRequestAuth(request, urlPath, body);

            var st = request.Body;

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        public static AmendOrderResponse ExecuteObj(AmendOrderForm info)
        {
            var json = Execute(info);

            var result =
                JsonSerializer.Deserialize<AmendOrderResponse>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }

    }
}

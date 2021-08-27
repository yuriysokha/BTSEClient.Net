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
        /// Amend a Limit or Trigger order. 
        /// If an order has been triggered, trigger price cannot be further modified.
        /// If order is a POST-ONLY order and `slide` option is set to true, then the price will set to the best bid/ask.
        /// </summary>
        public static string Execute(AmendOrderForm info)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.PUT);
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
        /// Amend a Limit or Trigger order. 
        /// If an order has been triggered, trigger price cannot be further modified.
        /// If order is a POST-ONLY order and `slide` option is set to true, then the price will set to the best bid/ask.
        /// </summary>
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

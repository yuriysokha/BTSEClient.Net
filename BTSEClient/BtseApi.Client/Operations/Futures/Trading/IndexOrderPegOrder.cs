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

using BtseApi.Client.DataClasses.Futures;

namespace BtseApi.Client.Operations.Futures.Trading
{
    public static class IndexOrderPegOrder
    {
        private static string urlPath = "/api/v2.1/order/peg";

        /// <summary>
        /// Places an order that tracks a certain percentage above/below the index price (deviation) of the specified market symbol. Order's price will change according to the current market index price. Stealth value functions like an iceberg order where only a certain percentage of orders is displayed on the orderbook.
        /// </summary>
        public static string Execute(PegOrderForm info)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;

            var body = JsonSerializer.Serialize(info);

            request.AddJsonBody(body);

            Helper.AddRequestAuth(request, urlPath, body);

            var st = request.Body;

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Places an order that tracks a certain percentage above/below the index price (deviation) of the specified market symbol. Order's price will change according to the current market index price. Stealth value functions like an iceberg order where only a certain percentage of orders is displayed on the orderbook.
        /// </summary>
        public static List<OrderResponse> ExecuteObj(PegOrderForm info)
        {
            var json = Execute(info);

            var result =
                JsonSerializer.Deserialize<List<OrderResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

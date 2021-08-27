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
    public static class ClosePosition
    {
        private static string urlPath = "/api/v2.1/order/close_position";

        /// <summary>
        /// Closes a user's position for the particular market as specified by symbol.
        /// If type is specified as LIMIT, then price is mandatory. 
        /// When type is MARKET, it closes the position at market price.
        /// </summary>
        public static string Execute(ClosePositionForm info)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.POST);

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
        /// Closes a user's position for the particular market as specified by symbol.
        /// If type is specified as LIMIT, then price is mandatory. 
        /// When type is MARKET, it closes the position at market price.
        /// </summary>
        public static List<OrderResponse> ExecuteObj(
            ClosePositionForm info)
        {
            var json = Execute(info);

            var result =
                JsonSerializer.Deserialize<List<OrderResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

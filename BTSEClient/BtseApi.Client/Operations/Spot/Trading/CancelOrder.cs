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

namespace BtseApi.Client.Operations.Spot.Trading
{
    public static class CancelOrder
    {
        private static string urlPath = "/api/v3.2/order";

        /// <summary>
        /// Cancels pending orders that has not yet been matched. 
        /// The orderID specifies which order to cancel. 
        /// When not sent in, all orders in the market will be cancelled.
        /// clOrderID is a custom ID sent by the client. 
        /// When sent in, all orders having this clOrderID will be cancelled.
        /// Both orderID and clOrderID are optional fields
        /// </summary>
        /// <param name="symbol">Market Symbol</param>
        /// <param name="orderId">Unique identifier for the order</param>
        /// <param name="clOrderId">Client custom ID</param>
        /// <returns>
        /// Cancels pending orders that has not yet been matched. 
        /// The orderID specifies which order to cancel. 
        /// When not sent in, all orders in the market will be cancelled.
        /// clOrderID is a custom ID sent by the client. 
        /// When sent in, all orders having this clOrderID will be cancelled.
        /// Both orderID and clOrderID are optional fields
        /// </returns>
        public static string Execute(string symbol, 
            string orderId = null, string clOrderId = null)
        {
            var client = Helper.GetClient(urlPath, true);

            var request = new RestRequest(Method.DELETE);
            request.RequestFormat = DataFormat.Json;

            if (symbol != null)
            {
                request.AddParameter("symbol", symbol, ParameterType.QueryString);
            }

            if (orderId != null)
            {
                request.AddParameter("orderID", orderId, ParameterType.QueryString);
            }

            if (clOrderId != null)
            {
                request.AddParameter("clOrderID", clOrderId, ParameterType.QueryString);
            }

            Helper.AddRequestAuth(request, urlPath, string.Empty);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Cancels pending orders that has not yet been matched. 
        /// The orderID specifies which order to cancel. 
        /// When not sent in, all orders in the market will be cancelled.
        /// clOrderID is a custom ID sent by the client. 
        /// When sent in, all orders having this clOrderID will be cancelled.
        /// Both orderID and clOrderID are optional fields
        /// </summary>
        /// <param name="symbol">Market Symbol</param>
        /// <param name="orderId">Unique identifier for the order</param>
        /// <param name="clOrderId">Client custom ID</param>
        /// <returns>
        /// Cancels pending orders that has not yet been matched. 
        /// The orderID specifies which order to cancel. 
        /// When not sent in, all orders in the market will be cancelled.
        /// clOrderID is a custom ID sent by the client. 
        /// When sent in, all orders having this clOrderID will be cancelled.
        /// Both orderID and clOrderID are optional fields
        /// </returns>
        public static List<CancelOrderResponse> ExecuteObj(string symbol,
            string orderId = null, string clOrderId = null)
        {
            var json = Execute(symbol, orderId, clOrderId);

            var result =
                JsonSerializer.Deserialize<List<CancelOrderResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

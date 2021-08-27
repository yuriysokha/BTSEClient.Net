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
    public static class CancelOrders
    {
        private static string urlPath = "/api/v2.1/order";

        /// <summary>
        /// The orderID specifies which order to cancel.When not sent, all orders in the market will be cancelled.clOrderID is a custom ID sent by the client.When sent in, all orders having this clOrderID will be cancelled.
        /// </summary>
        /// <param name="symbol">Market Symbol</param>
        /// <param name="orderId">Order ID to remove, if orderID and clOrderID is not specified, all orders in the specified market will be cancelled</param>
        /// <param name="clOrderId">Order clOrderID to remove, if it exists with orderID, then orderID has higher priority</param>
        /// <returns>
        /// The orderID specifies which order to cancel.When not sent, all orders in the market will be cancelled.clOrderID is a custom ID sent by the client.When sent in, all orders having this clOrderID will be cancelled.
        /// </returns>
        public static string Execute(string symbol,
            string orderId = null, string clOrderId = null)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.DELETE);
            request.RequestFormat = DataFormat.Json;

            request.AddParameter("symbol", symbol, ParameterType.QueryString);

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
        /// The orderID specifies which order to cancel.When not sent, all orders in the market will be cancelled.clOrderID is a custom ID sent by the client.When sent in, all orders having this clOrderID will be cancelled.
        /// </summary>
        /// <param name="symbol">Market Symbol</param>
        /// <param name="orderId">Order ID to remove, if orderID and clOrderID is not specified, all orders in the specified market will be cancelled</param>
        /// <param name="clOrderId">Order clOrderID to remove, if it exists with orderID, then orderID has higher priority</param>
        /// <returns>
        /// The orderID specifies which order to cancel.When not sent, all orders in the market will be cancelled.clOrderID is a custom ID sent by the client.When sent in, all orders having this clOrderID will be cancelled.
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

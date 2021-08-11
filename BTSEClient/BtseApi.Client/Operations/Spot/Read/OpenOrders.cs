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
    public static class OpenOrders
    {
        private static string urlPath = "/api/v3.2/user/open_orders";

        /// <summary>
        /// Retrieves open orders or also used to retrieve order status.
        /// If an order is cancelled or recently transacted, 
        /// the returned status field will indicate the state of the order.
        /// </summary>
        /// <param name="symbol">symbol (eg. BTCPFC, BTCZ19)</param>
        /// <param name="orderId">Each order has it's own orderID</param>
        /// <param name="clOrderId">When creating an order, clOrderID is a user defined order ID. If orderID and clOrder both exists is sent in this API, orderID will be used.</param>
        /// <returns>Retrieves open orders or also used to retrieve order status.
        /// If an order is cancelled or recently transacted, 
        /// the returned status field will indicate the state of the order.</returns>
        public static string Execute(
            string symbol,
            string orderId = null,
            string clOrderId = null
            )
        {
            var client = Helper.GetClient(urlPath, true);

            var request = new RestRequest(Method.GET);
            Helper.AddRequestAuth(request, urlPath, string.Empty);

            request.AddParameter("symbol", symbol, ParameterType.QueryString);

            if (orderId != null)
            {
                request.AddParameter("orderId", orderId, ParameterType.QueryString);
            }

            if (clOrderId != null)
            {
                request.AddParameter("clOrderId", clOrderId, ParameterType.QueryString);
            }

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Retrieves open orders or also used to retrieve order status.
        /// If an order is cancelled or recently transacted, 
        /// the returned status field will indicate the state of the order.
        /// </summary>
        /// <param name="symbol">symbol (eg. BTCPFC, BTCZ19)</param>
        /// <param name="orderId">Each order has it's own orderID</param>
        /// <param name="clOrderId">When creating an order, clOrderID is a user defined order ID. If orderID and clOrder both exists is sent in this API, orderID will be used.</param>
        /// <returns>Retrieves open orders or also used to retrieve order status.
        /// If an order is cancelled or recently transacted, 
        /// the returned status field will indicate the state of the order.</returns>
        public static List<OrderResponse> ExecuteObj(
            string symbol,
            string orderId = null,
            string clOrderId = null
            )
        {
            var json = Execute(symbol, orderId, clOrderId);

            var result =
                JsonSerializer.Deserialize<List<OrderResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

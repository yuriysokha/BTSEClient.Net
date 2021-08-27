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

namespace BtseApi.Client.Operations.Futures.Read
{
    public static class OpenOrders
    {
        private static string urlPath = "/api/v2.1/user/open_orders";

        /// <summary>
        /// Query returns orders that have not yet been transacted.
        /// If market symbol is specified, this API will only return orders for the specified market.
        /// If you would like to query a specific order with orderID or clOrderID then market symbol is compulsory.
        /// This API can also use to query the state of an order.
        /// The current order's state is returned in the orderState field.
        /// </summary>
        /// <param name="symbol">symbol (eg. BTCPFC, BTCZ19)</param>
        /// <param name="orderId">Each order has it's own orderID</param>
        /// <param name="clOrderId">When making an order, user can define what clOrderID they want to use.</param>
        /// <returns></returns>
        public static string Execute(
            string symbol = null,
            string orderId = null,
            string clOrderId = null
            )
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.GET);
            Helper.AddRequestAuth(request, urlPath, string.Empty);

            if (symbol != null)
            {
                request.AddParameter("symbol", symbol, ParameterType.QueryString);
            }

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
        /// Query returns orders that have not yet been transacted.
        /// If market symbol is specified, this API will only return orders for the specified market.
        /// If you would like to query a specific order with orderID or clOrderID then market symbol is compulsory.
        /// This API can also use to query the state of an order.
        /// The current order's state is returned in the orderState field.
        /// </summary>
        /// <param name="symbol">symbol (eg. BTCPFC, BTCZ19)</param>
        /// <param name="orderId">Each order has it's own orderID</param>
        /// <param name="clOrderId">When making an order, user can define what clOrderID they want to use.</param>
        /// <returns></returns>
        public static List<OpenOrderResponse> ExecuteObj(
            string symbol = null,
            string orderId = null,
            string clOrderId = null
            )
        {
            var json = Execute(symbol, orderId, clOrderId);

            var result =
                JsonSerializer.Deserialize<List<OpenOrderResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

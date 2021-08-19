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
    public static class TradeHistory
    {
        private static string urlPath = "/api/v3.2/user/trade_history";

        /// <summary>
        /// Retrieves user's trading history.
        /// </summary>
        /// <param name="symbol">Market symbol. Spot symbols are specified in
        /// <Base Currency>-<Quote Currency>(eg. BTC-USD, BTC-EUR)</param>
        /// <param name="startTime">The earliest timestamp to return result for</param>
        /// <param name="endTime">The latest timestamp to return result for</param>
        /// <param name="beforeSerialId">Query items before the ID number</param>
        /// <param name="afterSerialId">Query items after the ID number</param>
        /// <param name="count">Number of requested items, default = 10, max = 500</param>
        /// <param name="includeOld">Include trades older than 7 days, default = false</param>
        /// <param name="clOrderId">Query by a custom client order ID</param>
        /// <param name="orderId">Query trade history by order ID</param>
        /// <returns>Retrieves user's trading history.</returns>
        public static string Execute(
            string symbol = null,
            long? startTime = null,
            long? endTime = null,
            long? beforeSerialId = null,
            long? afterSerialId = null,
            int? count = null,
            bool? includeOld= null,
            string? clOrderId = null,
            string? orderId = null
            )
        {
            var client = Helper.GetClient(urlPath, true);

            var request = new RestRequest(Method.GET);
            Helper.AddRequestAuth(request, urlPath, string.Empty);

            if (symbol != null)
            {
                request.AddParameter("symbol", symbol, ParameterType.QueryString);
            }

            if (startTime != null)
            {
                request.AddParameter("startTime", startTime, ParameterType.QueryString);
            }

            if (endTime != null)
            {
                request.AddParameter("endTime", endTime, ParameterType.QueryString);
            }

            if (beforeSerialId != null)
            {
                request.AddParameter("beforeSerialId", beforeSerialId, ParameterType.QueryString);
            }

            if (afterSerialId != null)
            {
                request.AddParameter("afterSerialId", afterSerialId, ParameterType.QueryString);
            }

            if (count != null)
            {
                request.AddParameter("count", count, ParameterType.QueryString);
            }

            if (includeOld != null)
            {
                request.AddParameter("includeOld", includeOld, ParameterType.QueryString);
            }

            if (clOrderId != null)
            {
                request.AddParameter("clOrderId", clOrderId, ParameterType.QueryString);
            }

            if (orderId != null)
            {
                request.AddParameter("orderId", orderId, ParameterType.QueryString);
            }

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Retrieves user's trading history.
        /// </summary>
        /// <param name="symbol">Market symbol. Spot symbols are specified in
        /// <Base Currency>-<Quote Currency>(eg. BTC-USD, BTC-EUR)</param>
        /// <param name="startTime">The earliest timestamp to return result for</param>
        /// <param name="endTime">The latest timestamp to return result for</param>
        /// <param name="beforeSerialId">Query items before the ID number</param>
        /// <param name="afterSerialId">Query items after the ID number</param>
        /// <param name="count">Number of requested items, default = 10, max = 500</param>
        /// <param name="includeOld">Include trades older than 7 days, default = false</param>
        /// <param name="clOrderId">Query by a custom client order ID</param>
        /// <param name="orderId">Query trade history by order ID</param>
        /// <returns>Retrieves user's trading history.</returns>
        public static List<OrderHistoryResponse> ExecuteObj(
            string symbol = null,
            long? startTime = null,
            long? endTime = null,
            long? beforeSerialId = null,
            long? afterSerialId = null,
            int? count = null,
            bool? includeOld = null,
            string? clOrderId = null,
            string? orderId = null
            )
        {
            var json = Execute(
                symbol,
                startTime,
                endTime,
                beforeSerialId,
                afterSerialId,
                count,
                includeOld,
                clOrderId,
                orderId);

            var result =
                JsonSerializer.Deserialize<List<OrderHistoryResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

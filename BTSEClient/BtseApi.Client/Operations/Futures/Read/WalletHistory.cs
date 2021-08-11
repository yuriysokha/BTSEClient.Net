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
    public static class WalletHistory
    {
        private static string url = "/api/v2.1/user/wallet_history";

        /// <summary>
        /// Returns account's wallet history.
        /// API returns a maximum of 500 records at each time.
        /// </summary>
        /// <param name="wallet">Wallet name (eg. SPOT@, CORSS@, ISOLATED@BTCPFC-USD)</param>
        /// <param name="startTime">The earliest timestamp to return result for</param>
        /// <param name="endTime">The latest timestamp to return result for</param>
        /// <param name="count">Number of requested items, default = 10, max = 500</param>
        /// <returns>Returns account's wallet history. API returns a maximum of 500 records at each time.</returns>
        public static string Execute(
            string wallet = null,
            long? startTime = null,
            long? endTime = null,
            int? count = null)
        {
            var client = Helper.GetClient(url);

            var request = new RestRequest(Method.GET);

            if (wallet != null)
            {
                request.AddParameter("wallet", wallet, ParameterType.QueryString);
            }

            if (startTime.HasValue)
            {
                request.AddParameter("startTime", startTime, ParameterType.QueryString);
            }

            if (endTime != null)
            {
                request.AddParameter("endTime", endTime, ParameterType.QueryString);
            }

            if (count != null)
            {
                request.AddParameter("count", count, ParameterType.QueryString);
            }

            Helper.AddRequestAuth(request, url, string.Empty);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Returns account's wallet history.
        /// API returns a maximum of 500 records at each time.
        /// </summary>
        /// <param name="wallet">Wallet name (eg. SPOT@, CORSS@, ISOLATED@BTCPFC-USD)</param>
        /// <param name="startTime">The earliest timestamp to return result for</param>
        /// <param name="endTime">The latest timestamp to return result for</param>
        /// <param name="count">Number of requested items, default = 10, max = 500</param>
        /// <returns>Returns account's wallet history. API returns a maximum of 500 records at each time.</returns>
        public static List<WalletHistoryResponse> ExecuteObj(
           string wallet = null,
           long? startTime = null,
           long? endTime = null,
           int? count = null)
        {
            var json = Execute(wallet, startTime, endTime, count);

            var result =
               JsonSerializer.Deserialize<List<WalletHistoryResponse>>(json,
               new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

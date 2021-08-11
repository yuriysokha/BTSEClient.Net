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
    public static class SettlePositions
    {
        private static string urlPath = "/api/v2.1/settle_in";

        /// <summary>
        /// Sets the currency to settle the current position in
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="currency">Currency</param>
        /// <returns>Sets the currency to settle the current position in</returns>
        public static string Execute(string symbol, string currency)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;

            var body = String.Format("{{\"symbol\": \"{0}\",\"currency\": \"{1}\"}}", symbol, currency);

            request.AddBody(body);

            Helper.AddRequestAuth(request, urlPath, body);

            var st = request.Body;

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        public static SettleInResponse ExecuteObj(string symbol, string currency)
        {
            var json = Execute(symbol, currency);

            // this is not working for some reason because they return an empty 200 response
            var result =
                JsonSerializer.Deserialize<SettleInResponse>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }

    }
}

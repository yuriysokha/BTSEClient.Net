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
    public static class CancelAllAfter
    {
        private static string urlPath = "/api/v2.1/order/cancelAllAfter";

        /// <summary>
        /// Dead-man's switch to ensure your orders are cancelled in case of an outage.
        /// Invoke this API with the the timeout parameter specified in milliseconds (eg. 10000ms ie. 10secs).
        /// If an outage occurs within 10 seconds, on the 10th second, the system will cancel all futures orders.
        /// If the API is called repeatedly, upon each call to the API will extend the order's validity by the time specified in the input paramter.
        /// </summary>
        public static string Execute(CancelAllAfterRequest info)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.POST);
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
    }
}

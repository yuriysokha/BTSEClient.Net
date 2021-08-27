﻿using System;
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
    public static class LimitMarketOrder
    {
        private static string urlPath = "/api/v2.1/order";

        /// <summary>
        /// Place an order. Order types can be either Limit, Market or OCO by specifying different parameter types
        /// </summary>
        public static string Execute(OrderForm info)
        {
            var client = Helper.GetClient(urlPath);

            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;

            var options = new JsonSerializerOptions();
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            var body = JsonSerializer.Serialize(info, options);

            request.AddJsonBody(body);

            Helper.AddRequestAuth(request, urlPath, body);

            var st = request.Body;

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Place an order. Order types can be either Limit, Market or OCO by specifying different parameter types
        /// </summary>
        public static List<OrderResponse> ExecuteObj(OrderForm info)
        {
            var json = Execute(info);

            var result =
                JsonSerializer.Deserialize<List<OrderResponse>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

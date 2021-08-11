using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Text.Json;
using BtseApi.Client.DataClasses.Spot;
using BtseApi.Client.Helpers;

namespace BtseApi.Client.Operations.Spot.PublicEndpoints
{
    public static class GetsOrderBook
    {
        private static string url = "/api/v3.2/orderbook/";

        /// <summary>
        /// HTTP endpoint to retrieve Orderbook data. symbol is a mandatory field. L1
        /// </summary>
        /// <param name="symbol">Market symbol</param>
        /// <param name="group">Grouping. Default is 0, which is the finest granularity.</param>
        /// <param name="limitBids">Number of levels to show on bid side</param>
        /// <param name="limitAsks">Number of levels to show on the ask side</param>
        /// <returns>HTTP endpoint to retrieve Orderbook data. symbol is a mandatory field. L1</returns>
        public static string Execute(string symbol, int? group = null, int? limitBids = null, int? limitAsks = null)
        {
            var client = Helper.GetClient(url, true);

            var request = new RestRequest(Method.GET);

            request.AddParameter("symbol", symbol, ParameterType.QueryString);

            if(group.HasValue)
            {
                request.AddParameter("group", group, ParameterType.QueryString);
            }

            if (limitBids.HasValue)
            {
                request.AddParameter("limitBids", limitBids, ParameterType.QueryString);
            }

            if (limitAsks.HasValue)
            {
                request.AddParameter("limitAsks", limitAsks, ParameterType.QueryString);
            }

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// HTTP endpoint to retrieve Orderbook data. symbol is a mandatory field. L1
        /// </summary>
        /// <param name="symbol">Market symbol</param>
        /// <param name="group">Grouping. Default is 0, which is the finest granularity.</param>
        /// <param name="limitBids">Number of levels to show on bid side</param>
        /// <param name="limitAsks">Number of levels to show on the ask side</param>
        /// <returns>HTTP endpoint to retrieve Orderbook data. symbol is a mandatory field. L1</returns>
        public static OrderBookResponse ExecuteObj(string symbol, int? depth = null)
        {
            var json = Execute(symbol, depth);

            var result =
               JsonSerializer.Deserialize<OrderBookResponse> (json,
               new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}

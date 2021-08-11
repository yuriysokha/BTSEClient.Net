using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using RestSharp;

using BtseApi.Client.DataClasses.Spot;
using BtseApi.Client.Helpers;

namespace BtseApi.Client.Operations.Spot.PublicEndpoints
{
    public static class Ohlcv
    {
        private static string url = "/api/v3.2/ohlcv";

        /// <summary>
        /// Provides OHLCV (Open High Low Close Volume) for a market. 
        /// API provides up to a maximum of 300 data points each time. 
        /// This API is rate limited at 2 queries per second. 
        /// Dataset starts from October 2019.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC).</param>
        /// <param name="resolution">Resolution is provided in minutes.
        /// Supported resolutions:
        /// 1 = 1min
        /// 5 = 5mins
        /// 15 = 15mins
        /// 30 = 30mins
        /// 60 = 60mins
        /// 360 = 6hours
        /// 1440 = 1day</param>
        /// <param name="start">Start time of query in seconds. Query 300 time point after start given that end is null.</param>
        /// <param name="end">End time of query in seconds. Query 300 time point before end given that start is null.</param>
        /// <returns>Provides OHLCV (Open High Low Close Volume) for a market. </returns>
        public static string Execute(string symbol, long resolution, 
            long? start = null, long? end = null)
        {
            var client = Helper.GetClient(url, true);

            var request = new RestRequest(Method.GET);

            request.AddParameter("symbol", symbol, ParameterType.QueryString);
            request.AddParameter("resolution", resolution, ParameterType.QueryString);

            if(start.HasValue)
            {
                request.AddParameter("start", start, ParameterType.QueryString);
            }

            if (end.HasValue)
            {
                request.AddParameter("end", end, ParameterType.QueryString);
            }

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Provides OHLCV (Open High Low Close Volume) for a market. 
        /// API provides up to a maximum of 300 data points each time. 
        /// This API is rate limited at 2 queries per second. 
        /// Dataset starts from October 2019.
        /// </summary>
        /// <param name="symbol">Symbol representing the market (eg. BTCPFC, ETHPFC).</param>
        /// <param name="resolution">Resolution is provided in minutes.
        /// Supported resolutions:
        /// 1 = 1min
        /// 5 = 5mins
        /// 15 = 15mins
        /// 30 = 30mins
        /// 60 = 60mins
        /// 360 = 6hours
        /// 1440 = 1day</param>
        /// <param name="start">Start time of query in seconds. Query 300 time point after start given that end is null.</param>
        /// <param name="end">End time of query in seconds. Query 300 time point before end given that start is null.</param>
        /// <returns>Provides OHLCV (Open High Low Close Volume) for a market. </returns>
        public static List<OhlcvResponse> ExecuteObj(string symbol, long resolution,
            long? start = null, long? end = null)
        {
            var json = Execute(symbol, resolution,
                start, end);

            var resultList =
               JsonSerializer.Deserialize<List<decimal[]>>(json,
               new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            var result = new List<OhlcvResponse>(resultList.Count);

            resultList.ForEach(
                r =>
                {
                    result.Add(new OhlcvResponse { 
                        Time = (long)r[0],
                        Open = r[1],
                        High = r[2],
                        Low = r[3],
                        Close = r[4],
                        Volume = r[5] });
                });

            return result;
        }
    }
}

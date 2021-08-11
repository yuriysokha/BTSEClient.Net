using System;
using System.Text;

using System.Security.Cryptography;
using RestSharp;

using BtseApi.Client.DataClasses.Futures;
using BtseApi.Client.ApiSettings;
using BtseApi.Client.Helpers;


namespace BtseApi.Client.Helpers
{
    public static class Helper
    {
        public static string GetBtseHash(string secretkey, string urlpath, string btsenonce, string bodyStr)
        {
            HMACSHA384 hmac = new HMACSHA384(Encoding.ASCII.GetBytes(secretkey));

            byte[] hashValue = hmac.ComputeHash(Encoding.ASCII.GetBytes(urlpath + btsenonce + bodyStr));


            StringBuilder ret = new StringBuilder();

            for (int i = 0; i < hashValue.Length; i++)
                ret.Append(hashValue[i].ToString("x2"));

            return ret.ToString();
        }

        public static RestClient GetClient(string urlPath, bool isSpot = false)
        {
            var url = string.Empty;

            if (isSpot)
            {
                if (BtseSettings.IsProduction)
                {
                    url = BtseSettings.ProductionUrlSpot + urlPath;
                }
                else
                {
                    url = BtseSettings.TestnetUrlSpot + urlPath;
                }
            }
            else
            {
                if (BtseSettings.IsProduction)
                {
                    url = BtseSettings.ProductionUrlFutures + urlPath;
                }
                else
                {
                    url = BtseSettings.TestnetUrlFutures + urlPath;
                }
            }
            var client = new RestClient(url);

            client.Timeout = -1;

            return client;
        }

        public static void AddRequestAuth(RestRequest request, string urlPath, string bodyString)
        {
            var apiKey = BtseSettings.ApiKey;
            var secretkey = BtseSettings.Secretkey;

            if (BtseSettings.IsProduction)
            {
                apiKey = BtseSettings.ApiKey;
                secretkey = BtseSettings.Secretkey;
            }
            else
            {
                apiKey = BtseSettings.ApiKeyTestnet;
                secretkey = BtseSettings.SecretkeyTestnet;
            }


            var btsenonce = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();

            var bodyStr = bodyString;

            var hash = Helper.GetBtseHash(secretkey, urlPath, btsenonce, bodyStr);

            request.AddHeader("btse-nonce", btsenonce);
            request.AddHeader("btse-api", apiKey);
            request.AddHeader("btse-sign", hash);
        }
    }
}

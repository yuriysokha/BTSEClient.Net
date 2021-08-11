using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtseApi.Client.ApiSettings
{
    public static class BtseSettings
    {
        public static IConfigurationRoot Configuration { get; set; }

        static BtseSettings()
        {
            var builder = new ConfigurationBuilder();
                builder.AddJsonFile("jsconfig.json");

            Configuration = builder.Build();

            //var token = configuration.GetSection("ApiKey");
        }

        public static string ApiKey
        {
            get
            {
                return Configuration.GetSection("ApiKey").Value;
            }
        }

        public static string Secretkey
        {
            get
            {
                return Configuration.GetSection("Secretkey").Value;
            }
        }

        public static string ApiKeyTestnet
        {
            get
            {
                return Configuration.GetSection("ApiKeyTestnet").Value;
            }
        }

        public static string SecretkeyTestnet
        {
            get
            {
                return Configuration.GetSection("SecretkeyTestnet").Value;
            }
        }


        public static string UrlPath
        {
            get
            {
                return "/api/v3.2/";
            }
        }

        public static string ProductionUrlFutures
        {
            get
            {
                return "https://api.btse.com/futures";
            }
        }

        public static string TestnetUrlFutures
        {
            get
            {
                return "https://testapi.btse.io/futures";
            }
        }

        public static string ProductionUrlSpot
        {
            get
            {
                return "https://api.btse.com/spot";
            }
        }

        public static string TestnetUrlSpot
        {
            get
            {
                return "https://testapi.btse.io/spot";
            }
        }

        public static bool IsProduction
        {
            get
            {
                return Configuration.GetSection("IsProduction").Value == "true";
                //return true;
            }
        }
    }
}

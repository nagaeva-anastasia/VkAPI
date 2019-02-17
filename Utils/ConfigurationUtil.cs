using System;
using System.Configuration;

namespace VkAPI.Utils
{
    public class ConfigurationUtil
    {
        public static string ServerUrl = ConfigurationManager.AppSettings["ServerUrl"];
        public static string ServerResource = ConfigurationManager.AppSettings["ServerResource"];
        public static string APIVersion = ConfigurationManager.AppSettings["APIVersion"];
        public static string PathToData = ConfigurationManager.AppSettings["PathToData"];
        public static int ClientID = Convert.ToInt32(ConfigurationManager.AppSettings["ClientID"]);
        public static string ClientSecret = ConfigurationManager.AppSettings["ClientSecret"];
    }
}

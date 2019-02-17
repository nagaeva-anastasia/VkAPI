using System;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using VkAPI.BaseObjects;
using VkAPI.BaseObjects.Rest;
using VkAPI.Utils;

namespace VkAPI.Service
{
    /// <summary>
    /// Service to send \ receive requests using RestSharp
    /// </summary>
    public class RequestService
    {
        public static string ServerUrl = ConfigurationUtil.ServerUrl;
        public static string ServerResource = ConfigurationUtil.ServerResource;

        /// <summary>
        /// Send post request with data from IData object (e.g. User)
        /// </summary>
        private static IRestResponse SendPOSTRequest<T>(string methodName, T dataObject) where T : IData
        {
            RestClient client = new RestClient(ServerUrl);
            RestRequest request = new RestRequest(ServerResource + methodName, Method.POST);

            foreach (var property in typeof(T).GetProperties()) {
                var value = property.GetValue(dataObject);
            
                if (String.IsNullOrEmpty(value.ToString())) {
                    continue;
                }

                request.AddParameter(property.Name.ToLower(), value);
            }

            request.AddParameter("v", ConfigurationUtil.APIVersion);
            return client.Execute(request);
        }

        /// <summary>
        /// Send post request with data from IData object (e.g. User) 
        /// and get the result as Response
        /// </summary>
        public static Response GetResponse<T>(string methodName, T dataObject) where T : IData
        {
            Response resp = null;
            var response = SendPOSTRequest<T>(methodName, dataObject);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string rawResponse = response.Content;
                resp = JsonConvert.DeserializeObject<Response>(rawResponse);
            }

            return resp;
        }
    }
}

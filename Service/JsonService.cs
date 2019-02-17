using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using VkAPI.BaseObjects;
using VkAPI.Utils;

namespace VkAPI.Service
{
    /// <summary>
    /// Service to get data from JSON data files
    /// </summary>
    public class JsonService
    {
        public static string PathToData = ConfigurationUtil.PathToData;

        /// <summary>
        /// Get test data from json files
        /// </summary>
        public static T GetDataForTest<T>() where T : IData
        {
            string foldername = new StackFrame(1).GetMethod().DeclaringType.Name;
            string filename = foldername + ".json";
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), PathToData + foldername + "\\" + filename);
            StreamReader file = File.OpenText(path);
            JsonSerializer serializer = new JsonSerializer();
            return (T)serializer.Deserialize(file, typeof(T));
        }
    }
}

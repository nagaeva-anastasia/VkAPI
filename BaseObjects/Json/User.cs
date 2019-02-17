using System;
using VkAPI.Utils;

namespace VkAPI.BaseObjects
{
    /// <summary>
    /// JSON properties for vk user registered by phone number
    /// </summary>
    public class User : IData
    {
        public int Client_id { get { return ConfigurationUtil.ClientID; } }
        public string Client_secret { get { return ConfigurationUtil.ClientSecret; } }

        public string Phone { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Birthday { get; set; }
        public byte Sex { get; set; }
        public string Password { get; set; }
        public byte Voice { get; set; }
        public string Sid { get; set; }
        public byte Test_mode { get; set; }

        /// <summary>
        /// Generate any mobile phone with 11 digits, 
        /// starting from 89
        /// </summary>
        public string GenerateAnyPhone() {
            Phone = "89";
            var rand = new Random();
            for (int i = 2; i < 11; i++) { 
                Phone += rand.Next(0, 9);
            }
            return Phone;
        }
    }
}

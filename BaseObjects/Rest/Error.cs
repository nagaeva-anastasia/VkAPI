namespace VkAPI.BaseObjects.Rest
{
    /// <summary>
    /// Error after request with error code and message
    /// </summary>
    public class Error
    {
        public int Error_code { get; set; }
        public string Error_msg { get; set; }
    }
}

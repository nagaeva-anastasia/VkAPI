namespace VkAPI.BaseObjects.Rest
{
    /// <summary>
    /// Response with sid or error
    /// </summary>
    public class Response {
        public Error Error { get; set; }
        public string Sid { get; set; }
    }
}

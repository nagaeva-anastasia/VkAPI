using VkAPI.BaseObjects;
using VkAPI.BaseObjects.Rest;
using VkAPI.Service;

namespace VkAPI.DSL
{
    /// <summary>
    /// Auth methods
    /// </summary>
    public class Auth
    {
        static readonly string auth_signup = "auth.signup";

        /// <summary>
        /// Register new user by using auth.signup method
        /// </summary>
        public static Response RegisterUserBySignUp(User user) {
            return RequestService.GetResponse(auth_signup, user);
        }
    }
}

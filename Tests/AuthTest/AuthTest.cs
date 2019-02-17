using NUnit.Framework;
using VkAPI.BaseObjects;
using VkAPI.DSL;
using VkAPI.Service;

namespace VkAPI
{
    [TestFixture]
    public class AuthTest : BaseTest
    {
        [Test]
        public void PhoneIsMissingTest()
        {
            var user = JsonService.GetDataForTest<User>();
            var response = Auth.RegisterUserBySignUp(user);

            Assert.AreEqual(100, response.Error.Error_code, "Returned error code");
            Assert.AreEqual("One of the parameters specified was missing or invalid: phone is undefined", response.Error.Error_msg, "Returned error message");         
        }

        [Test]
        public void RegisterUserAndReturnSidTest()
        {
            var user = JsonService.GetDataForTest<User>();
            user.GenerateAnyPhone();

            var response = Auth.RegisterUserBySignUp(user);
            Assert.AreEqual(false, string.IsNullOrEmpty(response.Sid), "Returned SID is null or empty");
        }
    }
}

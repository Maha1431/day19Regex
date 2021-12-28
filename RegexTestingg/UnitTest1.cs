using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationUsingRegex;

namespace RegexTestingg
{
    [TestClass]
    public class UnitTest1
    {
        RegexUserRegistration regex = new RegexUserRegistration();

        [TestMethod]
        public void GivenFirstName_WhenValidate_ShouldRetrunTrue()
        {
            bool validresult = regex.ValidateFirstName("Maha");
            Assert.IsTrue(validresult);

        }
        [TestMethod]
        public void GivenLastName_WhenValidate_shouldReturnTrue()
        {
            bool validLastNameResult = regex.ValidateLastName("Lakshmi");
            Assert.IsTrue(validLastNameResult);

                
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_shouldReturntrue()
        {
            bool validMobileNumberResult = regex.ValidateMobileNumber("+91 8987765542");
            Assert.IsTrue(validMobileNumberResult);

        }
        [TestMethod]
        public void GivenEmail_WhenValidate_shouldReturnTrue()
        {
            bool validateEmailResult = regex.ValidateEmail("mahalakshmi11@com.in");
            Assert.IsTrue(validateEmailResult);
        }
        [TestMethod]
        public void GivenPassword_whenvalidate_shouldRetrunTrue()
        {
            bool validatePasswordResult = regex.ValidatePassword("shh87$sAe");
            Assert.IsTrue(validatePasswordResult);
        }

    }
}

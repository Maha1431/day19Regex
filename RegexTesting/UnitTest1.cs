using NUnit.Framework;
using ValidationUsingRegex;

namespace RegexTesting
{
    public class Tests
    {
        RegexUserRegistration regex = new RegexUserRegistration();

        [Test]
        public void GivenFirstname_whenValidate_shouldReturntrue()
        {
            bool validresult = regex.ValidateFirstName("755fff");
            Assert.IsFalse(validresult);
        }
        [Test]
        public void GivenLastName_whenvalidate_shouldReturnTrue()
        {
            bool validLastNameResult = regex.ValidateLastName("Lakshmi");
            Assert.IsTrue(validLastNameResult);

        }
        [Test]
        public void GivenMobileNumber_whenValidate_shouldReturnTrue()
        {
            bool validMobileNumberResult = regex.ValidateMobileNumber("862658898");
            Assert.IsTrue(validMobileNumberResult);
        }

    }
}
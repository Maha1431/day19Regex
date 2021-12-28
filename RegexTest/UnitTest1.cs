using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationUsingRegex;

namespace RegexTest
{
    [TestClass]
    public class UnitTest1
    { 
        RegexUserRegistration regex = new RegexUserRegistration();
        [TestMethod]
        public void TestMethod1()
        {
            bool Result = regex.ValidateFirstName("maha");
            Assert.IsTrue( Result);
        }
    }
}
            
    
    

    





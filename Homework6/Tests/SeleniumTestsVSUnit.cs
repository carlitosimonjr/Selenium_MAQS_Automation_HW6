using CognizantSoftvision.Maqs.BaseSeleniumTest;
using CognizantSoftvision.Maqs.Utilities.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageModel;
using System;

namespace Tests
{
    /// <summary>
    /// SeleniumTest test class with VS unit
    /// </summary>
    [TestClass]
    public class SeleniumTestsVSUnit : BaseSeleniumTest
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("Class setup");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("Test cleanup");
        }

        /// <summary>
        /// Enter invalid credentials test
        /// </summary>
        [TestMethod]
        [DataRow("ted", "123")]
        [DataRow("tEd", "123")]
        [DataRow("Ted", "124")]
        [DataRow("Ted", "125")]
        [DataRow("Ted", "126")]
        public void EnterInvalidCredentials(string username, string password)
        {
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            Assert.IsTrue(page.LoginWithInvalidCredentials(username, password));
        }
    }
}

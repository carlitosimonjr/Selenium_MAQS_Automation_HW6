using CognizantSoftvision.Maqs.BaseSeleniumTest;
using CognizantSoftvision.Maqs.BaseSeleniumTest.Extensions;
using OpenQA.Selenium;

namespace PageModel
{
    /// <summary>
    /// Page object for HowItWorksPageModel
    /// </summary>
    public class HowItWorksPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// The page url
        /// </summary>
        private static string PageUrl = SeleniumConfig.GetWebSiteBase() + "Static/Training2/HowWork.html";

        /// <summary>
        /// Initializes a new instance of the <see cref="HowItWorksPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public HowItWorksPageModel(ISeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Sample lazy element
        /// </summary>
        private LazyElement Sample
        {
            get { return this.GetLazyElement(By.CssSelector("#CSS_ID"), "Sample message"); }
        }

        /// <summary>
        /// Open the page
        /// </summary>
        public void OpenPage()
        {
            // sample open login page
            this.TestObject.WebDriver.Navigate().GoToUrl(PageUrl);
        }

        /// <summary>
        /// Check if the login page is loaded
        /// </summary>
        public override bool IsPageLoaded()
        {
            return this.WebDriver.Url.Equals(PageUrl, System.StringComparison.CurrentCultureIgnoreCase);
        }
    }
}

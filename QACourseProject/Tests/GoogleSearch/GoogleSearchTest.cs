using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectInProgres.Pages.GoogleSearchPages;

namespace ProjectInProgres.Tests.GoogleSearch
{
    class GoogleSearchTest : BaseTest
    {
        private GoogleSearchPage _googleSearchPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _googleSearchPage = new GoogleSearchPage(Driver);
            Driver.GoToUrl(_googleSearchPage.URL);

        }
        [Test]
        public void SearchForSelenium()
        {
            _googleSearchPage.SearchSection.SendKeys("selenium");
            _googleSearchPage.SearchSection.SendKeys(Keys.Enter);
            
            _googleSearchPage.FirstResult.Click();
           
            Assert.AreEqual("SeleniumHQ Browser Automation", _googleSearchPage.FirstResultTitle);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                TakeScreenshot(@"..\..\..\");
            }

            Driver.Quit();
        }
    }
}

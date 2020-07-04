using NUnit.Framework;
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
            Driver.Navigate("http://google.com");
            _googleSearchPage = new GoogleSearchPage(Driver);

        }
        [Test]
        public void SearchForSelenium()
        {
            _googleSearchPage.SearchSection.SetText("selenium").Submit();
            
            _googleSearchPage.FirstResult.Click();
           
            Driver.Wait.Until(ExpectedConditions.TitleIs("SeleniumHQ Browser Automation"));
            Assert.AreEqual("SeleniumHQ Browser Automation", _googleSearchPage.FirstResultTitle);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.GetScreenShot();
            Driver.Quit();
        }
    }
}

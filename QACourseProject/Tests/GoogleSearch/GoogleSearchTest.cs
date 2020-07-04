using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectInProgres.Pages.GoogleSearchPages;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenShot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                screenShot.SaveAsFile($@"C:\ScreenshotImage\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }
            Driver.Quit();
        }
    }
}

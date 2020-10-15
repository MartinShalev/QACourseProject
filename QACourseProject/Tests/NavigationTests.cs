using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ProjectInProgres;
using ProjectInProgres.Pages;
using ProjectInProgres.Pages.HmoePage;
using ProjectInProgres.Tests;

namespace LiveDemoSeleniumAdvanced
{
    public class NavigationTests : BaseTest
    {
        private HomePage _homePage;
        private DemoQAPage _demoQaPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _homePage = new HomePage(Driver);
            _demoQaPage = new DemoQAPage(Driver);
            Driver.GoToUrl(_homePage.URL);
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void SuccessfullyPageLoaded_When_NavigateToSortable(string sectionName)
        {
            _homePage.CategotyButton("Interactions").Click();
            
            Driver.ScrollToElement(_demoQaPage.SubMenu(sectionName));
            _demoQaPage.SubMenu(sectionName).Click();

            _demoQaPage.AssertPageTitle(sectionName);

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

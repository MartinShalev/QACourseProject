using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
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
            _homePage.NaviteTo();
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
            
            Driver.ScrollTo(_demoQaPage.SubMenu(sectionName));
            _demoQaPage.SubMenu(sectionName).Click();

            _demoQaPage.AssertPageTitle(sectionName);

        }

        [TearDown]
        public void TearDown()
        {
            Driver.GetScreenShot();
            Driver.Quit();
        }
    }
}

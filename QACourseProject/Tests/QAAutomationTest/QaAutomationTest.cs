using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ProjectInProgres.Pages.QAautomation;

namespace ProjectInProgres.Tests.QAAutomationTest
{
    public class QaAutomationTest : BaseTest
    {
        private QaAutomationPage _QaAutomationPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate("http://softuni.bg");
            _QaAutomationPage = new QaAutomationPage(Driver);
        }
        [Test]
        public void QACours()
        {
            if (!_QaAutomationPage.NavLearningButton.WrappedElement.Displayed)
            {
                _QaAutomationPage.NavButton.Click();
                _QaAutomationPage.LearningButton.Click();
            }
            else
            {
              _QaAutomationPage.NavLearningButton.Click();
            }
            _QaAutomationPage.ActivModuls.Click();
            _QaAutomationPage.QaAutomationSection.Click();
            Driver.ScrollTo(_QaAutomationPage.CourseButton).Click();
           
            Assert.AreEqual("Курс QA Automation - май 2020 - Софтуерен университет", _QaAutomationPage.CoursePageTitle);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.GetScreenShot();
            Driver.Quit();
        }
    }
}

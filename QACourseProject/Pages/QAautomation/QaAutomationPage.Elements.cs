using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.QAautomation
{
    public partial class QaAutomationPage
    {
        public CustomWebElement LearningButton => Driver.FindElement(By.XPath("//span[normalize-space(text())='Обучения']"));
        public CustomWebElement NavButton => Driver.FindElement(By.XPath("//div[@class='nav-buttons']//i[@class='fa fa-bars']"));
        public CustomWebElement NavLearningButton => Driver.FindElement(By.XPath("//*[@class= 'toggle-nav toggle-holder']//*[normalize-space(text())='Обучения']"));
        public CustomWebElement ActivModuls => Driver.FindElement(By.XPath("//*[@class= 'col-md-6 no-padding']//*[normalize-space(text())='Активни модули']"));
        public CustomWebElement QaAutomationSection => Driver.FindElement(By.XPath("//*[@class= 'my-collapsible-body category-list']//*//*[normalize-space(text())='Quality Assurance - октомври 2019']"));
        public CustomWebElement CourseButton => Driver.FindElement(By.XPath("//*[@class= 'course-instance-box']//*[normalize-space(text())='QA Automation']"));
        public string CoursePageTitle => Driver.WrappedDriver.Title;
    }
}

using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.QAautomation
{
    public partial class QaAutomationPage
    {
        public WebElement LearningButton => Driver.FindElement(By.XPath("//span[normalize-space(text())='Обучения']"));
        public WebElement NavButton => Driver.FindElement(By.XPath("//div[@class='nav-buttons']//i[@class='fa fa-bars']"));
        public WebElement NavLearningButton => Driver.FindElement(By.XPath("//*[@class= 'toggle-nav toggle-holder']//*[normalize-space(text())='Обучения']"));
        public WebElement ActivModuls => Driver.FindElement(By.XPath("//*[@class= 'col-md-6 no-padding']//*[normalize-space(text())='Активни модули']"));
        public WebElement QaAutomationSection => Driver.FindElement(By.XPath("//*[@class= 'my-collapsible-body category-list']//*//*[normalize-space(text())='Quality Assurance - октомври 2019']"));
        public WebElement CourseButton => Driver.FindElement(By.XPath("//*[@class= 'course-instance-box']//*[normalize-space(text())='QA Automation']"));
        public string CoursePageTitle => Driver.WrappedDriver.Title;
    }
}

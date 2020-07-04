using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages
{
    public partial class DemoQAPage
    {
        protected CustomWebElement LeftPanel => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));

        public CustomWebElement InteractionsButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text())='Interactions']"));

        public CustomWebElement SubMenu (string subName) => LeftPanel.FindElement(By.XPath($".//*[normalize-space(text())='{subName}']"));

        public CustomWebElement PageTitle => Driver.FindElement(By.ClassName("main-header"));
    }
}   

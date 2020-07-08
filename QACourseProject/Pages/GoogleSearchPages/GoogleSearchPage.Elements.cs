using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;

namespace ProjectInProgres.Pages.GoogleSearchPages
{
    public partial class GoogleSearchPage
    {
        public CustomWebElement SearchSection => Driver.FindElement(By.XPath("//*[@class= 'gLFyf gsfi']"));
        public CustomWebElement FirstResult => Driver.FindElement(By.XPath("//*[@class= 'r']//*[@href='https://www.selenium.dev/']"));
        public string FirstResultTitle => Driver.WrappedDriver.Title;
    }
}

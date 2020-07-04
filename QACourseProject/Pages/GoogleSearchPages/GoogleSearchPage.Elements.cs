using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.GoogleSearchPages
{
    public partial class GoogleSearchPage
    {
        public CustomWebElement SearchSection => Driver.FindElement(By.XPath("//*[@class= 'gLFyf gsfi']"));
        public CustomWebElement FirstResult => Driver.FindElement(By.XPath("//*[@class= 'rc']//h3[normalize-space(text())='Selenium']"));
        public String FirstResultTitle => Driver.WrappedDriver.Title;
    }
}

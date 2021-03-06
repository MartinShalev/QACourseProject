﻿using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages
{
    public partial class DemoQAPage
    {
        protected WebElement LeftPanel => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));
        public WebElement InteractionsButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text())='Interactions']"));
        public WebElement SubMenu (string subName) => LeftPanel.FindElement(By.XPath($".//*[normalize-space(text())='{subName}']"));
        public WebElement PageTitle => Driver.FindElement(By.ClassName("main-header"));
    }
}   

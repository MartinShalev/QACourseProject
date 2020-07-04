using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using StabilizeTestsDemos.ThirdVersion;
using System;

namespace ProjectInProgres.Pages.PracticsForm
{
    public abstract class BasePage
    {
        public BasePage(CustomWebDriver driver)
        {
            Driver = driver;
          
        }
        public virtual string Url { get; }
        public CustomWebDriver Driver { get; }

        public void NaviteTo()
        {
            Driver.Navigate(Url);
        }
    }
}

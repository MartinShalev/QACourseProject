using OpenQA.Selenium;
using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.GoogleSearchPages
{
    public partial class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(CustomWebDriver driver)
            :base(driver)
        {
        }
        public override string Url => "http://google.com";
    }
}

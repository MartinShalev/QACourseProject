using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class HomePage : BasePage
    {
        public HomePage(CustomWebDriver driver)
            :base(driver)
        {
        }

        public override string Url => "http://automationpractice.com/index.php";
        public void ClickSingButton()
        {
            SignInButton.Click();
        }
    }
    
}

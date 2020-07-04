using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class HomePage : BasePage
    {
       
        public CustomWebElement SignInButton => Driver.FindElement(By.ClassName("header_user_info"));

    }
    
}

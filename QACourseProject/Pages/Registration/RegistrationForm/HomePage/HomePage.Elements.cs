﻿using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class HomePage : BasePage
    {
        public WebElement SignInButton => Driver.FindElement(By.ClassName("header_user_info"));
    }    
}

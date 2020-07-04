﻿using AutoFixture;
using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class SignPage : BasePage
    {
        
        public CustomWebElement EmailField => Driver.FindElement(By.Id("email_create"));
       
        public CustomWebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));

       
    }
}
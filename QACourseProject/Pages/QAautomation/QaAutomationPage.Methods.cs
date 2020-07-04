using OpenQA.Selenium;
using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.QAautomation
{
    public partial class QaAutomationPage : BasePage
    {
        public QaAutomationPage(CustomWebDriver driver) : base(driver)
        {
        }
        public override string Url => "https://softuni.bg";
    }  
}

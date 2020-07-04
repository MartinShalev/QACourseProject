using OpenQA.Selenium;
using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.ResizablePage
{
     public partial class ResizablePage : BasePage
    {
        public ResizablePage(CustomWebDriver driver)
            :base(driver)
        {       
        }
        public override string Url => "http://demoqa.com/resizable";

    }
}

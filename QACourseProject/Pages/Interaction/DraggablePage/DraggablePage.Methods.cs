using OpenQA.Selenium;
using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.HmoePage.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(CustomWebDriver driver) : base(driver)
        {
        }
        public override string Url => "http://demoqa.com/dragabble";


    }

}

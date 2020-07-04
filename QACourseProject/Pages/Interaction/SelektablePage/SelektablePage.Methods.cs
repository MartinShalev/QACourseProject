using OpenQA.Selenium;
using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.SelektablePage
{
    public partial class SelektablePage : BasePage
    {
        public SelektablePage(CustomWebDriver driver)
            :base(driver)
        {

        }
        public override string Url => "http://demoqa.com/selectable";

        public void SelectAllElements()
        {
            foreach (var option in Listoptions)
            {
                option.Click();
            }
        }

    }
}

using OpenQA.Selenium;
using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.HmoePage
{
    public partial class HomePage : BasePage 
    {
        public HomePage(CustomWebDriver driver)  : base(driver)
        {
        }
        public override string Url => "http://demoqa.com";
    }
}

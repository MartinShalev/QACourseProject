using OpenQA.Selenium.Interactions;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.PracticsForm
{
    public abstract class BasePage
    {
        public BasePage(WebDriver driver)
        {
            Driver = driver;
            Builder = new Actions(Driver.WrappedDriver);

        }

        public WebDriver Driver { get; }

        protected Actions Builder { get; set; }

    }
}

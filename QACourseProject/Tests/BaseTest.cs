using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected CustomWebDriver Driver { get; set; }

        protected Actions Builder { get; set; }

        public void Initialize()
        {
            Driver = new CustomWebDriver();
            Driver.StartHeadless(Browser.Chrome);
            Driver.WrappedDriver.Manage().Window.Maximize();
            Builder = new Actions(Driver.WrappedDriver);
        }
    }
}

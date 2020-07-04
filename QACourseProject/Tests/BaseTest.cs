using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.IO;
using System.Reflection;

namespace ProjectInProgres.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected CustomWebDriver Driver { get; set; }

        protected Actions Builder { get; set; }

        public void Initialize()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("-headless");
            // Driver = new RemoteWebDriver(new Uri("http://192.168.1.14:4444/wd/hub"), options);
            // Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            // Driver.WrappedDriver.Manage().Window.Maximize();

            Driver = new CustomWebDriver();
            Driver.StartHeadless(Browser.Chrome);
            Driver.WrappedDriver.Manage().Window.Maximize();
            Builder = new Actions(Driver.WrappedDriver);
        }

    }

}

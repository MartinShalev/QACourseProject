using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace StabilizeTestsDemos.ThirdVersion
{
    public class CustomWebDriver
    {
        private IWebDriver _nativeWebDriver;
        private WebDriverWait _webDriverWait;

        public IWebDriver WrappedDriver => _nativeWebDriver;

        public WebDriverWait Wait => _webDriverWait;

        public void Start(Browser browser)
        {   
            _nativeWebDriver = browser switch
            {
                Browser.Chrome => new ChromeDriver(Environment.CurrentDirectory),
                Browser.Firefox => new FirefoxDriver(Environment.CurrentDirectory),
                Browser.Edge => new EdgeDriver(Environment.CurrentDirectory),
                Browser.Opera => new OperaDriver(Environment.CurrentDirectory),
                Browser.Safari => new SafariDriver(Environment.CurrentDirectory),
                Browser.InternetExplorer => new InternetExplorerDriver(Environment.CurrentDirectory),
                _ => throw new ArgumentOutOfRangeException(nameof(browser), browser, null),
            };
            _webDriverWait = new WebDriverWait(_nativeWebDriver, TimeSpan.FromSeconds(30));
            
        }

        public void StartHeadless(Browser browser)
        {
            var argument = "-headless";
            switch (browser)
            {
                case Browser.Chrome:
                    ChromeOptions optionsChrome = new ChromeOptions();
                    optionsChrome.AddArgument(argument);
                    _nativeWebDriver = new ChromeDriver(Environment.CurrentDirectory, optionsChrome);
                    break;
                case Browser.Firefox:
                    FirefoxOptions optionsFirefox = new FirefoxOptions();
                    optionsFirefox.AddArgument(argument);
                    _nativeWebDriver = new FirefoxDriver(Environment.CurrentDirectory, optionsFirefox);
                    break;
                case Browser.Opera:
                    OperaOptions optionsOpera = new OperaOptions();
                    optionsOpera.AddArgument(argument);
                    _nativeWebDriver = new OperaDriver(Environment.CurrentDirectory, optionsOpera);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }
            _webDriverWait = new WebDriverWait(_nativeWebDriver, TimeSpan.FromSeconds(30));

        }

        public void Quit()
        {
            _nativeWebDriver.Quit();
        }

        public CustomWebElement FindElement(By locator)
        {
            IWebElement nativeWebElement =
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            CustomWebElement element = new CustomWebElement(_nativeWebDriver, nativeWebElement, locator);

            return element;
        }

        public List<CustomWebElement> FindElements(By locator)
        {
            ReadOnlyCollection<IWebElement> nativeWebElements =
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            var elements = new List<CustomWebElement>();
            foreach (var nativeWebElement in nativeWebElements)
            {
                CustomWebElement element = new CustomWebElement(_nativeWebDriver, nativeWebElement, locator);
                elements.Add(element);
            }

            return elements;
        }

        public void Navigate(string url)
        {
            WrappedDriver.Navigate().GoToUrl(url);
        }

        public CustomWebElement ScrollTo(CustomWebElement element)
        {
            ((IJavaScriptExecutor)element.WrappedDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element.WrappedElement);
            return element;
        }

        public void PageReady(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WrappedDriver;
            WebDriverWait wait = new WebDriverWait(WrappedDriver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }

      


    }

}

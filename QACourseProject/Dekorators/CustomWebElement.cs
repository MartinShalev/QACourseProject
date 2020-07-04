using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;

namespace StabilizeTestsDemos.ThirdVersion
{
    public class CustomWebElement
    {
        private readonly IWebDriver _webDriver;
        private readonly IWebElement _webElement;
        private readonly By _by;

        public CustomWebElement(IWebDriver webDriver, IWebElement webElement, By by)
        {
            _webDriver = webDriver;
            _webElement = webElement;
            _by = by;
        }

        public IWebElement WrappedElement => _webElement;

        public IWebDriver WrappedDriver => _webDriver;

        public By By => _by;

        public string Text => _webElement?.Text;

        public bool? Enabled => _webElement?.Enabled;

        public bool? Displayed => _webElement?.Displayed;

        internal CustomWebElement FindElement(By by)
        {
            var wait = new WebDriverWait(WrappedDriver, TimeSpan.FromSeconds(20));
            IWebElement nativeWebElement =
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
            CustomWebElement element = new CustomWebElement(_webDriver, nativeWebElement, by);

            return element;
        }
        public List<CustomWebElement> FindElements(By by)
        {
            var elements = new List<CustomWebElement>();
            ReadOnlyCollection<IWebElement> innerElements = _webElement.FindElements(by);
            foreach (var nativeWebElement in innerElements)
            {
                CustomWebElement element = new CustomWebElement(_webDriver, nativeWebElement, by);
                elements.Add(element);
            }
            return elements;
        }
        public Size Size => WrappedElement.Size;
        public Point Location => WrappedElement.Location;
        public void Click()
        {
            WaitToBeClickable(By);
            _webElement?.Click();
        }
        public CustomWebElement SetText(string text)
        {
            _webElement.Clear();
            _webElement.SendKeys(text);
            return this;
        }
        public void Submit()
        {
            _webElement.Submit();
        }
        public string GetAttribute(string attributeName)
        {
            return _webElement?.GetAttribute(attributeName);
        }
        public string GetCssValue(string cssValue)
        {
            return _webElement.GetCssValue(cssValue);
        }
        private void WaitToBeClickable(By by)
        {
            var webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
    }
}

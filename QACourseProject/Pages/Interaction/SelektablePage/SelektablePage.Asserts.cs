using NUnit.Framework;
using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.SelektablePage
{
    public partial class SelektablePage
    {
        public void AssertBlueBackGroundFor(CustomWebElement selectableElement)
        {
            Assert.AreEqual("rgba(0, 123, 255, 1)", selectableElement.GetCssValue("background-color"));
        }
    }
}

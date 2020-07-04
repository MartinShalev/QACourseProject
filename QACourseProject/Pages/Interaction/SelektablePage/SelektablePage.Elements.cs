using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ProjectInProgres.Pages.SelektablePage
{
    public partial class SelektablePage
    {
        public CustomWebElement Lists => Driver.FindElement(By.Id("verticalListContainer"));

        public List<CustomWebElement> Listoptions => Driver.FindElements(By.XPath("//ul[@id='verticalListContainer']/li"));
    }
}

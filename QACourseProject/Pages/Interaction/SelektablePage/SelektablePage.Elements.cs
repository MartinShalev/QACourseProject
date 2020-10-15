using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;

namespace ProjectInProgres.Pages.SelektablePage
{
    public partial class SelektablePage
    {
        public WebElement Lists => Driver.FindElement(By.Id("verticalListContainer"));
        public List<WebElement> Listoptions => Driver.FindElements(By.XPath("//ul[@id='verticalListContainer']/li"));
    }
}

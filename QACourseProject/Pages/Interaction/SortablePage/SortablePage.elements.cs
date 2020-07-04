using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;
using System.Linq;

namespace ProjectInProgres.Pages
{
    public partial class SortablePage
    {
         public List<CustomWebElement> ListOfOptions => Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList();
    }
}
using OpenQA.Selenium;
using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.HmoePage
{
    public partial class HomePage : BasePage
    {
        public CustomWebElement CategotyButton(string categoryName) =>
             Driver.FindElement(By.XPath($"//*[normalize-space(text())='{categoryName}']/ancestor::div[contains(@class, 'top-card')]"));
    }
}


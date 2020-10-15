using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class SignPage : BasePage
    {
        public WebElement EmailField => Driver.FindElement(By.Id("email_create"));
        public WebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));
    }
}

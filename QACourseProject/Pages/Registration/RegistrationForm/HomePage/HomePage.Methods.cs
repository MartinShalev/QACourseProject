using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class HomePage : BasePage
    {
        public HomePage(WebDriver driver)
            : base(driver)
        {
        }
        public string URL { get { return "http://automationpractice.com/index.php"; } }
        public void ClickSingButton()
        {
            SignInButton.Click();
        }
    }
}

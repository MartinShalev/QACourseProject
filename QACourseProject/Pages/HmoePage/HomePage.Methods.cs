using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.HmoePage
{
    public partial class HomePage : BasePage 
    {
        public HomePage(WebDriver driver)  : base(driver)
        {
        }
        public string URL { get { return "http://demoqa.com"; } }
    }
}

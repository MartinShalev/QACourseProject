using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.GoogleSearchPages
{
    public partial class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(WebDriver driver)
            :base(driver)
        {
        }
        public string  URL { get {return "http://google.com"; } }
    }
}

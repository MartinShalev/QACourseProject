using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.GoogleSearchPages
{
    public partial class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(CustomWebDriver driver)
            :base(driver)
        {
        }
        public override string Url => "http://google.com";
    }
}

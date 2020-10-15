using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(WebDriver driver)
            : base(driver)
        {
        }
        public string URL { get { return "http://demoqa.com/resizable"; } }
    }
}

using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(CustomWebDriver driver)
            :base(driver)
        {       
        }
        public override string Url => "http://demoqa.com/resizable";
    }
}

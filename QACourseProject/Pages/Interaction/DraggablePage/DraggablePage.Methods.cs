using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.HmoePage.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(WebDriver driver) : base(driver)
        {
        }
        public string URL { get { return "http://demoqa.com/dragabble"; } }

    }
}

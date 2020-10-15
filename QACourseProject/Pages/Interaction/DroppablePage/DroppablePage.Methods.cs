using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(WebDriver driver) : base(driver)
        {
        }
        public string URL { get { return "http://demoqa.com/droppable"; } }

        public string GetColorOfTargetBox()
        {
            return TargertBox.GetCssValue("background-color");
        }
    }
}

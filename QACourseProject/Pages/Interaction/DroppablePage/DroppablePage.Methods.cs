using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(CustomWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://demoqa.com/droppable";

        public string GetColorOfTargetBox()
        {
            return TargertBox.GetCssValue("background-color");
        }
    }
}

using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.SelektablePage
{
    public partial class SelektablePage : BasePage
    {
        public SelektablePage(CustomWebDriver driver)
            :base(driver)
        {
        }
        public override string Url => "http://demoqa.com/selectable";
        public void SelectAllElements()
        {
            foreach (var option in Listoptions)
            {
                option.Click();
            }
        }
    }
}

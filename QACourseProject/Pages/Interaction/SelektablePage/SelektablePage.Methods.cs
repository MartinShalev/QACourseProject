using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.SelektablePage
{
    public partial class SelektablePage : BasePage
    {
        public SelektablePage(WebDriver driver)
            : base(driver)
        {
        }
        public string URL { get { return "http://demoqa.com/selectable"; } }
        public void SelectAllElements()
        {
            foreach (var option in Listoptions)
            {
                option.Click();
            }
        }
    }
}

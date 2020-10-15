using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.QAautomation
{
    public partial class QaAutomationPage : BasePage
    {
        public QaAutomationPage(WebDriver driver) : base(driver)
        {
        }
        public string URL { get { return "https://softuni.bg"; } }
    }
}

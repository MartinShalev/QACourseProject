using ProjectInProgres.Pages.PracticsForm;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.QAautomation
{
    public partial class QaAutomationPage : BasePage
    {
        public QaAutomationPage(CustomWebDriver driver) : base(driver)
        {
        }
        public override string Url => "https://softuni.bg";
    }  
}

using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages
{
    public partial class SortablePage : DemoQAPage
    {
        public SortablePage(WebDriver driver)
            : base(driver)
        {
        }
        public string URL { get { return "http://demoqa.com/sortable"; } }
    }
}

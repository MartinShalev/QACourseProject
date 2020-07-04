using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages
{
    public partial class SortablePage : DemoQAPage
    {
        public SortablePage(CustomWebDriver driver)
            : base(driver)
        {
        }
        public override string Url => "http://demoqa.com/sortable";       
    }
}

using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        public CustomWebElement DragPoint => Driver.FindElement(By.XPath("//*[@id=\"resizableBoxWithRestriction\"]/span"));
       
    }
}

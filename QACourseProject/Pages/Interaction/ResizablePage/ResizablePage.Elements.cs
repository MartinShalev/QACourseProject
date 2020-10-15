using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        public WebElement DragPoint => Driver.FindElement(By.XPath("//*[@id=\"resizableBoxWithRestriction\"]/span"));
       
    }
}

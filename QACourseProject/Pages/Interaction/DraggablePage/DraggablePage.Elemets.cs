using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.HmoePage.DraggablePage
{
    public partial class DraggablePage
    {
        public WebElement AxisRestrictedTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));
        public WebElement OnlyXBox => Driver.FindElement(By.Id("restrictedX"));
        public WebElement OnlyYBox => Driver.FindElement(By.Id("restrictedY"));
        public WebElement ContainerRestriction => Driver.FindElement(By.Id("draggableExample-tab-containerRestriction"));
        public WebElement Container  => Driver.FindElement(By.Id("containmentWrapper"));
        public WebElement DragabbleBox => Driver.FindElement(By.XPath("//div[@id='containmentWrapper']/div"));
    }          
}

using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.DroppablePage
{
    public partial class DroppablePage
    {
        public WebElement SourseBox => Driver.FindElement(By.Id("draggable"));
        public WebElement TargertBox => Driver.FindElement(By.Id("droppable"));
        public WebElement AcceptSectionTargetBox => Driver.FindElement(By.XPath("//div[@class='accept-drop-container']/div[@id='droppable']"));
        public WebElement AcceptSection => Driver.FindElement(By.Id("droppableExample-tab-accept"));
        public WebElement NotAcceptableBox => Driver.FindElement(By.Id("notAcceptable"));
    }
    
}

using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.DroppablePage
{
    public partial class DroppablePage
    {
        public CustomWebElement SourseBox => Driver.FindElement(By.Id("draggable"));

        public CustomWebElement TargertBox => Driver.FindElement(By.Id("droppable"));
        public CustomWebElement AcceptSectionTargetBox => Driver.FindElement(By.XPath("//div[@class='accept-drop-container']/div[@id='droppable']"));
        public CustomWebElement AcceptSection => Driver.FindElement(By.Id("droppableExample-tab-accept"));

        public CustomWebElement NotAcceptableBox => Driver.FindElement(By.Id("notAcceptable"));
    }
    
}

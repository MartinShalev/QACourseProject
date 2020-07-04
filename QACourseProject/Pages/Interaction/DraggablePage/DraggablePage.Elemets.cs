using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.HmoePage.DraggablePage
{
    public partial class DraggablePage
    {
        public CustomWebElement AxisRestrictedTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));
        public CustomWebElement OnlyXBox => Driver.FindElement(By.Id("restrictedX"));
        public CustomWebElement OnlyYBox => Driver.FindElement(By.Id("restrictedY"));
        public CustomWebElement ContainerRestriction => Driver.FindElement(By.Id("draggableExample-tab-containerRestriction"));
        public CustomWebElement Container  => Driver.FindElement(By.Id("containmentWrapper"));
        public CustomWebElement DragabbleBox => Driver.FindElement(By.XPath("//div[@id='containmentWrapper']/div"));
    }          
}

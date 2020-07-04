using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        public CustomWebElement DragPoint => Driver.FindElement(By.XPath("//*[@id=\"resizableBoxWithRestriction\"]/span"));

        
    }
}

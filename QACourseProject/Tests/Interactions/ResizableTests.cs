using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ProjectInProgres.Pages.ResizablePage;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Tests.Interactions
{
    public class ResizableTests : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate("http://demoqa.com/resizable");
            _resizablePage = new ResizablePage(Driver);


        }
        [Test]
        public void ResizableTest_1()
        {
            //Put elemet locations in elemet
            var locationXBefore = _resizablePage.DragPoint.Location.X;

            Builder.ClickAndHold(_resizablePage.DragPoint.WrappedElement)
                .MoveByOffset(50, 50)
                .Release()
                .Perform();

            var locationXAfter = _resizablePage.DragPoint.Location.X;

            Assert.AreNotEqual(locationXBefore, locationXAfter);
        }

        [Test]
        public void ResizableTest_2()
        {
            var locationXBefore = _resizablePage.DragPoint.Location.X;
            var locationYBefore = _resizablePage.DragPoint.Location.Y;

            Builder.ClickAndHold(_resizablePage.DragPoint.WrappedElement)
                .MoveByOffset(-100, -100)
                .Release()
                .Perform();

            var locationXAfter = _resizablePage.DragPoint.Location.X;
            var locationYAfter = _resizablePage.DragPoint.Location.Y;

            Assert.AreEqual(locationXBefore - 50, locationXAfter);
            Assert.AreEqual(locationYBefore - 50, locationYAfter);

        }


        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenShot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                screenShot.SaveAsFile($@"C:\ScreenshotImage\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }
    }
}

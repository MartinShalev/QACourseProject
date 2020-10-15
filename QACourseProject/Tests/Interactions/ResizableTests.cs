using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ProjectInProgres.Pages.ResizablePage;

namespace ProjectInProgres.Tests.Interactions
{
    public class ResizableTests : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _resizablePage = new ResizablePage(Driver);
            Driver.GoToUrl(_resizablePage.URL);
        }
        [Test]
        public void ResizableTest_1()
        {
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
                TakeScreenshot(@"..\..\..\");
            }

            Driver.Quit();
        }
    }
}

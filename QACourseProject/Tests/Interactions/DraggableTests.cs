using NUnit.Framework;
using OpenQA.Selenium;
using ProjectInProgres.Pages.HmoePage.DraggablePage;

namespace ProjectInProgres.Tests.Interactions
{
    public class DraggableTests : BaseTest
    {
        private DraggablePage _draggablePage;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate("http://demoqa.com/dragabble");
            _draggablePage = new DraggablePage(Driver);
        }

        [Test]
        public void ElementYIsSame_When_DragAndDropOnlyXDiagonally()
        {
            _draggablePage.AxisRestrictedTab.Click();

            var yBefore = _draggablePage.OnlyXBox.Location.Y;
            Builder.DragAndDropToOffset(_draggablePage.OnlyXBox.WrappedElement, 100, 100).Perform();
            var yAfter = _draggablePage.OnlyXBox.Location.Y;

            Assert.AreEqual(yBefore, yAfter);
        }
        [Test]
        public void ElementYIsSame_When_DragAndDropOnlyYDiagonally()
        {
            _draggablePage.AxisRestrictedTab.Click();

            var xBefore = _draggablePage.OnlyXBox.Location.X;
            Builder.DragAndDropToOffset(_draggablePage.OnlyYBox.WrappedElement, 100, 100).Perform();
            var xAfter = _draggablePage.OnlyXBox.Location.X;

            Assert.AreEqual(xBefore, xAfter);
        }
        [Test]
        public void ElementStillInBox_When_DragAndDropOutOfBox()
        {
            _draggablePage.ContainerRestriction.Click();

            Builder.DragAndDropToOffset(_draggablePage.DragabbleBox.WrappedElement, 0, _draggablePage.Container.Size.Height - 100).Perform();

            Assert.IsNotNull(_draggablePage.Container.FindElement(By.TagName("div")));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.GetScreenShot();
            Driver.Quit();
        }
    }
}

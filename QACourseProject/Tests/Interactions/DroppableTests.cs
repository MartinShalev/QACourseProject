using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ProjectInProgres.Pages.DroppablePage;

namespace ProjectInProgres.Tests.Interactions
{
    public class DroppableTests : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            Driver.GoToUrl(_droppablePage.URL);
        }
        [Test]
        public void DropBoxOnTarget()
        {
            var colorBefore = _droppablePage.GetColorOfTargetBox();

            Builder.DragAndDrop(_droppablePage.SourseBox.WrappedElement,
                _droppablePage.TargertBox.WrappedElement).Perform();

            var colorAfter = _droppablePage.GetColorOfTargetBox();

            Assert.AreNotEqual(colorBefore, colorAfter);
        }
        [Test]
        public void DropBoxOutOfTarget()
        {
            var colorBefore = _droppablePage.GetColorOfTargetBox();

            Builder.MoveToElement(_droppablePage.SourseBox.WrappedElement).ClickAndHold().MoveByOffset(500, 200).Perform();

            var colorAfter = _droppablePage.GetColorOfTargetBox();

            Assert.AreEqual(colorBefore, colorAfter);
        }
        [Test]
        public void TargetColorNotChanged_When_DragNotAcceptableElement()

        {
            _droppablePage.AcceptSection.Click();

            var colorBefore = _droppablePage.GetColorOfTargetBox();

            Builder.ClickAndHold(_droppablePage.NotAcceptableBox.WrappedElement)
                .MoveToElement(_droppablePage.AcceptSectionTargetBox.WrappedElement)
                .Release()
                .Perform();

            var colorAfter = _droppablePage.GetColorOfTargetBox();

            Assert.AreEqual(colorBefore, colorAfter);
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

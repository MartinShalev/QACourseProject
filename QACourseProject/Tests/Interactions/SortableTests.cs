using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ProjectInProgres.Pages;

namespace ProjectInProgres.Tests
{
    [TestFixture]
    public class SortableTests : BaseTest
    {
        private SortablePage _sortablePage;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            Driver.GoToUrl(_sortablePage.URL);
        }
        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropUnderOtherOption()
        {
            var index = 1;

            Builder.DragAndDropToOffset(_sortablePage.ListOfOptions[index].WrappedElement, 0, 50).Perform();

            _sortablePage.AssertTextByIndex("Two", index + 1);
        }

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropOverOtherOption()
        {
            var index = 4;

            Driver.ScrollToElement(_sortablePage.ListOfOptions[index]);

            Builder.ClickAndHold(_sortablePage.ListOfOptions[index].WrappedElement)
                .MoveToElement(_sortablePage.ListOfOptions[index + 1].WrappedElement).Release().Perform();

            _sortablePage.AssertTextByIndex("Five", index + 1);
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

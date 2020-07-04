﻿using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ProjectInProgres.Pages.SelektablePage;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInProgres.Tests.Interactions
{
    [TestFixture]
    public class SelectableTest : BaseTest
    {
        private SelektablePage _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate("http://demoqa.com/selectable");
            _selectablePage = new SelektablePage(Driver);

        }
        [Test]
        public void SelectItemColorChange_When_SelectItem([Range(0, 3)] int index)
        {
            Driver.ScrollTo(_selectablePage.Listoptions[1]);

            _selectablePage.Listoptions[index].Click();

            _selectablePage.AssertBlueBackGroundFor(_selectablePage.Listoptions[index]);
        }

        [Test]
        public void AllItemsColorChanged_When_MoreThanIOneItem()
        {
             Driver.ScrollTo(_selectablePage.Listoptions[1]);

            foreach (var option in _selectablePage.Listoptions)
            {
                option.Click();

                _selectablePage.AssertBlueBackGroundFor(option);

            }

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

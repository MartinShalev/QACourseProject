﻿using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ProjectInProgres.Pages.SelektablePage;
using System;

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
            _selectablePage = new SelektablePage(Driver);
            Driver.GoToUrl(_selectablePage.URL);
        }
        [Test]
        public void SelectItemColorChange_When_SelectItem([Range(0, 3)] int index)
        {
            Driver.ScrollDown(50);

            _selectablePage.Listoptions[index].Click();

            _selectablePage.AssertBlueBackGroundFor(_selectablePage.Listoptions[index]);
        }
        [Test]
        public void AllItemsColorChanged_When_MoreThanIOneItem()
        {
             Driver.ScrollDown(50);

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
                TakeScreenshot(@"..\..\..\");
            }

            Driver.Quit();
        }
    }
}

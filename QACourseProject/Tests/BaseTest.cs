﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.IO;
using System.Threading;

namespace ProjectInProgres.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected WebDriver Driver { get; set; }
        protected Actions Builder { get; set; }
        protected IJavaScriptExecutor JS { get; set; }


        public void Initialize()
        {
            Driver = new WebDriver();
            Driver.StartHeadless(Browser.Chrome);
            Builder = new Actions(Driver.WrappedDriver);
            JS = (IJavaScriptExecutor)Driver.WrappedDriver;
            Driver.WrappedDriver.Manage().Window.Maximize();
        }
        public void TakeScreenshot(string relativePath)
        {
            string dirPath = Path.GetFullPath(relativePath, Directory.GetCurrentDirectory());
            Thread.Sleep(500);
            var screenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
            string testName = TestContext.CurrentContext.Test.Name.Replace("\"", "");
            screenshot.SaveAsFile($"{dirPath}\\Screenshot\\{testName}_{DateTime.Now:ddMMyy-HH_mm}.png", ScreenshotImageFormat.Png);
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class RegistrationPage : BasePage
    {
        public void AssertErrorMessageIs(string message)
        {
            Assert.AreEqual(ErrorMessage.Text, message);
        }

        public void AssertAcountNameIs(string fullName)
        {
            Assert.AreEqual(fullName, AcountName.Text);
        }
        
    }
}

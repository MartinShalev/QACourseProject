using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ProjectInProgres.Pages.PracticsForm;
namespace ProjectInProgres.Tests
{
    [TestFixture]
    public class RegistrationPageTest : BaseTest
    {
        private UserModel _user;
        private HomePage _homePage;
        private SignPage _signPage;
        private RegistrationPage _registracionForm;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _homePage = new HomePage(Driver);
            _homePage.NaviteTo();
            _user = UserFactory.CreateValidUser();
            _signPage = new SignPage(Driver);
            _registracionForm = new RegistrationPage(Driver);
           
        }
        private void NavigateToSignPage()
        {
            _homePage.SignInButton.WrappedElement.Click();
            _signPage.SignIn_With_RandomEmail();
            _signPage.CreateAccountButton.WrappedElement.Click();
        }

        [Test]
        public void SuccessfullyRegistracion()
        {
            NavigateToSignPage();

            _registracionForm.FillRegistrationForm(_user);

            _registracionForm.AssertAcountNameIs(_user.GetFullName());

        }
        [Test]
        public void RegistracionWithoutFirstName()
        {
            NavigateToSignPage();

            _user.FirstName = string.Empty;
            _registracionForm.FillRegistrationForm(_user);

            _registracionForm.AssertErrorMessageIs("firstname is required.");
        }
        [Test]
        public void RegistracionWithoutLastName()
        {
            NavigateToSignPage();

            _user.LastName = string.Empty;
            _registracionForm.FillRegistrationForm(_user);

            _registracionForm.AssertErrorMessageIs("lastname is required.");
        }
        [Test]
        public void RegistracionWithoutPassword()
        {

            NavigateToSignPage();

            _user.Password = string.Empty;
            _registracionForm.FillRegistrationForm(_user);

            _registracionForm.AssertErrorMessageIs("passwd is required.");
        }
        [Test]
        public void RegistracionWithoutAddress()
        {
            NavigateToSignPage();
            _user.Addres = string.Empty;
            _registracionForm.FillRegistrationForm(_user);

           _registracionForm.AssertErrorMessageIs("address1 is required.");
        }
        [Test]
        public void RegistracionWithoutPostalCode()
        {
            NavigateToSignPage();

            _user.PostalCode = 0 ;
            _registracionForm.FillRegistrationForm(_user);

           _registracionForm.AssertErrorMessageIs("The Zip/Postal code you've entered is invalid. It must follow this format: 00000");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.GetScreenShot();
            Driver.Quit();
        }
    }
}

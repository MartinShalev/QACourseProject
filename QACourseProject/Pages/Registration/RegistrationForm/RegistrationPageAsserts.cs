using NUnit.Framework;

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

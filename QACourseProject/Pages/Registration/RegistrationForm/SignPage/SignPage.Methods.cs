using AutoFixture;
using StabilizeTestsDemos.ThirdVersion;
using System;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class SignPage : BasePage
    {
        public SignPage(WebDriver driver)
            : base(driver)
        {
        }
        public string URL { get { return "http://automationpractice.com/index.php?controller=authentication&back=my-account"; } }
        public void SignIn_With_RandomEmail()
        {
            var fixture = new Fixture();
            var emailAddressField = fixture.Create<String>();
            EmailField.TypeText($"{emailAddressField}@gmail.com");

            CreateAccountButton.Click();
        }
    }
}

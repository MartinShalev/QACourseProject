using AutoFixture;
using StabilizeTestsDemos.ThirdVersion;
using System;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class SignPage : BasePage
    {
        public SignPage(CustomWebDriver driver)
            :base(driver)
        {
        }
        public override string Url => ("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        public void SignIn_With_RandomEmail()
        {
            var fixture = new Fixture();
            var emailAddressField = fixture.Create<String>();
            EmailField.SetText($"{emailAddressField}@gmail.com");

            CreateAccountButton.Click();
        }
    }
}

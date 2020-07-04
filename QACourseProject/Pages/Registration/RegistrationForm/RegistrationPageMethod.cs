using OpenQA.Selenium.Support.UI;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(CustomWebDriver driver)
            : base(driver)
        {
        }
        public override string Url => "http://automationpractice.com/index.php";
        public void FillRegistrationForm(UserModel user)
        {
            Gender(user.Gender).Click();
            FirstName.SetText(user.FirstName);
            LastName.SetText(user.LastName);
            Password.SetText(user.Password);
            DayOfBirth.WrappedElement.SendKeys(user.DayOfBirth);
            new SelectElement(MonthOfBirth.WrappedElement).SelectByValue(user.MonthOfBirth);
            YearOfBirth.WrappedElement.SendKeys(user.YearOfBirth);
            Addres.SetText(user.Addres);
            City.SetText(user.City);
            new SelectElement(State.WrappedElement).SelectByValue(user.State.ToString());
            PostalCode.SetText(user.PostalCode.ToString());
            MobilePhone.SetText(user.MobilePhone);
            SubmitButton.Click();
        }
    }
}

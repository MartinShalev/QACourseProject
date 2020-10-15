using OpenQA.Selenium.Support.UI;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(WebDriver driver)
            : base(driver)
        {
        }
        public string URL { get { return "http://automationpractice.com/index.php"; } }
        public void FillRegistrationForm(UserModel user)
        {
            Gender(user.Gender).Click();
            FirstName.TypeText(user.FirstName);
            LastName.TypeText(user.LastName);
            Password.TypeText(user.Password);
            DayOfBirth.WrappedElement.SendKeys(user.DayOfBirth);
            new SelectElement(MonthOfBirth.WrappedElement).SelectByValue(user.MonthOfBirth);
            YearOfBirth.WrappedElement.SendKeys(user.YearOfBirth);
            Addres.TypeText(user.Addres);
            City.TypeText(user.City);
            new SelectElement(State.WrappedElement).SelectByValue(user.State.ToString());
            PostalCode.TypeText(user.PostalCode.ToString());
            MobilePhone.TypeText(user.MobilePhone);
            SubmitButton.Click();
        }
    }
}

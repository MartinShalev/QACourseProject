using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class RegistrationPage : BasePage
    {
        public WebElement Gender(string gender) =>
            Driver.FindElement(By.Id($"uniform-id_gender{gender}"));
        public WebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));
        public WebElement LastName => Driver.FindElement(By.Id("customer_lastname"));
        public WebElement Password => Driver.FindElement(By.Id("passwd"));
        public WebElement DayOfBirth => Driver.FindElement(By.Id("days"));
        public WebElement MonthOfBirth => Driver.FindElement(By.Id("months"));
        public WebElement YearOfBirth => Driver.FindElement(By.Id("years"));
        public WebElement AddressFirstName => Driver.FindElement(By.Id("firstname"));
        public WebElement AddressLastName => Driver.FindElement(By.Id("lastname"));
        public WebElement Addres => Driver.FindElement(By.Id("address1"));
        public WebElement City => Driver.FindElement(By.Id("city"));
        public WebElement State => Driver.FindElement(By.Id("id_state"));
        public WebElement PostalCode => Driver.FindElement(By.Id("postcode"));
        public WebElement Country => Driver.FindElement(By.Id("id_country"));
        public WebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));
        public WebElement ReferenceAddres => Driver.FindElement(By.Id("alias"));
        public WebElement SubmitButton => Driver.FindElement(By.Id("submitAccount"));
        public WebElement ErrorMessage => Driver.FindElement(By.XPath("//*//*[@class= 'alert alert-danger']//li"));
        public WebElement AcountName => Driver.FindElement(By.ClassName("header_user_info"));
    }
}

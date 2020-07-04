using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.PracticsForm
{
    public partial class RegistrationPage : BasePage
    {

        public CustomWebElement Gender(string gender) =>
            Driver.FindElement(By.Id($"uniform-id_gender{gender}"));

        public CustomWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public CustomWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public CustomWebElement Password => Driver.FindElement(By.Id("passwd"));

        public CustomWebElement DayOfBirth => Driver.FindElement(By.Id("days"));

        public CustomWebElement MonthOfBirth => Driver.FindElement(By.Id("months"));

        public CustomWebElement YearOfBirth => Driver.FindElement(By.Id("years"));

        public CustomWebElement AddressFirstName => Driver.FindElement(By.Id("firstname"));

        public CustomWebElement AddressLastName => Driver.FindElement(By.Id("lastname"));

        public CustomWebElement Addres => Driver.FindElement(By.Id("address1"));

        public CustomWebElement City => Driver.FindElement(By.Id("city"));

        public CustomWebElement State => Driver.FindElement(By.Id("id_state"));

        public CustomWebElement PostalCode => Driver.FindElement(By.Id("postcode"));

        public CustomWebElement Country => Driver.FindElement(By.Id("id_country"));

        public CustomWebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));

        public CustomWebElement ReferenceAddres => Driver.FindElement(By.Id("alias"));

        public CustomWebElement SubmitButton => Driver.FindElement(By.Id("submitAccount"));

        public CustomWebElement ErrorMessage => Driver.FindElement(By.XPath("//*//*[@class= 'alert alert-danger']//li"));

        public CustomWebElement AcountName => Driver.FindElement(By.ClassName("header_user_info"));


    }
}

using AutoFixture;
using ProjectInProgres.UsersTools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace ProjectInProgres
{
    public static class UserFactory
    {

        public static UserModel CreateValidUser()
        {

            var random = new Random();
            var fixture = new Fixture();
            fixture.Customizations.Add(new RandomDateTimeSequenceGenerator(new DateTime(1990, 1, 1), new DateTime(2020, 4, 30)));
            var dateTime = fixture.Create<DateTime>();
            var genderMapping = new Dictionary<string, string>
            {
                { "Mr.", "1" },
                { "Mrs.", "2" }
            };

            return new UserModel
            {
                FirstName = fixture.CreateRandomString(8),
                LastName = fixture.CreateRandomString(8),
                YearOfBirth = dateTime.Year.ToString(),
                MonthOfBirth = dateTime.Month.ToString(),
                DayOfBirth = dateTime.Day.ToString(),
                Password = fixture.Create<string>().Substring(0, 31),
                Gender = genderMapping["Mr."],
                PostalCode = random.Next(10000, 99999).ToString(),
                MobilePhone = fixture.Create<Contact>().Telephone,
                Addres = "4716  Felosa Drive",
                City = "Los Angeles",
                State = random.Next(1, 50).ToString()

            };

        }

    }
    public class Contact
    {
        [RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$")]
        public string Telephone { get; set; }
    }

}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectInProgres
{
    public  class UserModel
    {
        public string Gender { get; set; }
        [MinLength(3),MaxLength(8)]
        public string FirstName { get; set; }
        [MinLength(3),MaxLength(8)]
        public string LastName { get; set; }
        public string Password { get; set; }
        public string DayOfBirth { get; set; }
        public string MonthOfBirth { get; set; }
        public string YearOfBirth { get; set; }
        public string AddresFirstName { get; set; }
        public string AddresLastName { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string MobilePhone { get; set; }
        public string ReferenceAddres { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectMatch
{
    class UserInfo
    {
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }

        public UserInfo()
        {
            FirstName = "";
            Gender = "";
            Hometown = "";
            Height = 0.0;
            Age = 0;
            Phone = 0;
        }
        public UserInfo(string firstName, string gender, string hometown, double height, int age, int phone)
        {
            FirstName = firstName;
            Gender = gender;
            Hometown = hometown;
            Height = height;
            Age = age;
            Phone = phone;
        }
        public override string ToString()
        {
            //creates an output of string 
            string UserAsString = $"{FirstName} {Gender} {Height} is {Age} and is from {Hometown}. {FirstName}'s phone number is {Phone}.";

            return UserAsString;
        }

    }
}

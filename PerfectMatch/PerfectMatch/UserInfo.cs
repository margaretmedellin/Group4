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
        public string HomeState { get; set; }
        public string University { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        //public LocalDataStoreSlot DB_128040_group4Entities<UserInfo1_> dB {get;}


        public UserInfo()
        {
            FirstName = "";
            Gender = "";
            HomeState = "";
            University = "";
            Phone = "";
            Age = 0;

        }
        public UserInfo(string firstName, string gender, string hometown, string university, int age, string phone)
        {
            FirstName = firstName;
            Gender = gender;
            HomeState = hometown;
            University = university;
            Phone = phone;
            Age = age;
        }
        ////public override string ToString()
        //{
        //    //creates an output of string 
        //    string UserAsString = $"{FirstName} {Gender} is {Age} and is from {HomeState}. {FirstName} currently attends {University} {FirstName}'s phone number is {Phone}.";

        //    return UserAsString;
        //}
    }
}

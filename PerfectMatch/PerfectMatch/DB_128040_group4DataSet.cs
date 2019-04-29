using System;

namespace PerfectMatch
{


    public partial class DB_128040_group4DataSet
    {
     
            public string HomeState { get; set; }
            public string FirstName { get; set; }
            public string Phone { get; set; }
            public string University { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }

            public DB_128040_group4DataSet(string firstName, string gender, string hometown, string university, int age, string phone)
            {
                FirstName = firstName;
                Gender = gender;
                HomeState = hometown;
                University = university;
                Phone = phone;
                Age = age;
            }
        }
    }


////public override string ToString()
//{
//    //creates an output of string 
//    string UserAsString = $"{FirstName} {Gender} is {Age} and is from {HomeState}. {FirstName} currently attends {University} {FirstName}'s phone number is {Phone}.";

//    return UserAsString;
//}




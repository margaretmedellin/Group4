//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerfectMatch
{
    using System;
    using System.Collections.Generic;

    public partial class UserInfo
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string HomeState { get; set; }
        public string University { get; set; }
        public string ProfilePic { get; set; }

        public UserInfo()
        {
            UserID = 0;
            FirstName = "";
            Gender = "";
            Age = 0;
            Phone = "";
            HomeState = "";
            University = "";
            ProfilePic = "";
        }

        public override string ToString()
        {
            return FirstName + " | " + Age + " | " + Gender + " | " + University + " | " + HomeState + " | ";
        }

    }
}

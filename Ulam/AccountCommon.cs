using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlamCommon
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateOnly Birthday{ get; set; }

        public List<Ulam> favorites;
        public Account()
        {

        }
        public Account(string username, string password, string firstName, string lastName, string gender, DateOnly birthday)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Birthday = birthday;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public User() { }

        public User(String Username, String Password, String FirstName, String LastName, String PhoneNumber, String Address, String Email)
        {
            this.Username = Username;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Email = Email;
        }

        public override string ToString()
        {
            return "Users{" +
               "username='" + Username + '\'' +
               ", password='" + Password + '\'' +
               ", firstName='" + FirstName + '\'' +
               ", lastName='" + LastName + '\'' +
               ", phoneNumber='" + PhoneNumber + '\'' +
               ", address='" + Address + '\'' +
               ", email='" + Email + '\'' +
               '}';
        }
    }
}

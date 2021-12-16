using System;

namespace SpaDay.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; }

        public User()
        {
            DateCreated = DateTime.Now;
        }

        public User(string userName, string password, string email) : this()
        {
            UserName = userName;
            Password = password;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"userName: {UserName} email: {Email}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Finde.Core.Domain
{
    public class User
    {
        private static readonly Regex UsernameRegex = new Regex("^(?![_.-])(?!.*[_.-]{2})[a-zA-Z0-9._.-]+(?<![_.-])$");
        private static readonly Regex NameRegex = new Regex("^[a - z,.'-]+$/i");

        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string Username { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        protected User() { }

        public User(Guid userId, string email, string password, string salt, string hash, string username)
        {
            Id = userId;
            SetEmail(email);
            SetPassword(password, salt);
            SetUserName(username);
            CreatedAt = DateTime.UtcNow;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email can not be empty.");
            }
            if(Email == email)
            {
                return;
            }
            Email = email.ToLowerInvariant();
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetUserName(string name)
        {
            if (!UsernameRegex.IsMatch(name))
            {
                throw new Exception("Username can not be invalid.");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Username can not be empty.");
            }
            if(Username == name)
            {
                return;
            }

            Username = name;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetPassword(string password, string salt)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password can not be empty.");
            }
            if(string.IsNullOrWhiteSpace(salt))
            {
                throw new Exception("Salt can not be empty.");
            }
            if(password.Length < 6)
            {
                throw new Exception("Password is too short.");
            }
            if(password.Length > 40)
            {
                throw new Exception("Password can not contain more than 40 characters.");
            }
            if(Password == password)
            {
                return;
            }

            Password = password;
            Salt = salt;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetFirstName(string name)
        {
            if (!NameRegex.IsMatch(name))
            {
                throw new Exception("First name can not be invalid.");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("First name can not be empty.");
            }
            if(FirstName == name)
            {
                return;
            }

            FirstName = name;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetLastName(string name)
        {
            if (!NameRegex.IsMatch(name))
            {
                throw new Exception("Last name can not be invalid.");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Last name can not be empty.");
            }
            if (LastName == name)
            {
                return;
            }

            LastName = name;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

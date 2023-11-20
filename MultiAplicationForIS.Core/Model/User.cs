﻿
namespace MultiAplicationForIS.Core.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }
    }
}

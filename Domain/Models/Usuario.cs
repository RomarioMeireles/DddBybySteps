using System;

namespace Domain.Models
{
    public class Usuario:Entity<string>
    {
        public Usuario()
        {

        }
        public Usuario(string userName, string password)
        {
            Id = Guid.NewGuid().ToString();
            UserName = userName;
            Password = password;
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }

    }
}


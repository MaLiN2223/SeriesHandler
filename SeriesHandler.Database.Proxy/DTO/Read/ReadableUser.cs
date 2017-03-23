using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeriesHandler.Database.Connector;

namespace SeriesHandler.Database.Proxy.DTO.Read
{
    public class ReadableUser
    {
        public ReadableUser() { }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Surname { get; set; }
        public byte Permission { get; set; }
        public string Email { get; set; }

        public ReadableUser(User user)
        {
            Name = user.name;
            Username = user.username;
            Surname = user.surname;
            Email = user.email;
        }

    }
}

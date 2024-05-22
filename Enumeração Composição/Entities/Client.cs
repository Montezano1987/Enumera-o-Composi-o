using System;
using System.Text;

namespace Enumeração_Composição.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email{ get; set; }
        public DateOnly BirthDate { get; set; }

        public Client()
        {
        }

        public Client (string name,  string email, DateOnly birthdate)
        {
            Name = name;
            Email = email;
            BirthDate = birthdate;
        }
    }
}

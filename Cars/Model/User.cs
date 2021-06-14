using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Model
{
    public record User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string position { get; set; }
        public string email { get; set; }
        public string username { get; set; }

        List<CarRental> CarRentals { get; set; }

        public User(int id, string name, string surname, DateTime dateOfBirth, string position, string email, string username)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.position = position;
            this.email = email;
            this.username = username;
        }
    }
}

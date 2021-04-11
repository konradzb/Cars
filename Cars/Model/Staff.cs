using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Model
{
    public class Staff
    {
        public static int lastId = 0;
        public int id { get; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string position { get; set; }
        
        public Staff(string name, string surname, DateTime dateOfBirth, string position)
        {
            this.id = lastId++;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.position = position;
        }

    }
}

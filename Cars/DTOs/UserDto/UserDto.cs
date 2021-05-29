using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.DTOs
{
    public record UserDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string position { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string username { get; set; }
    }
}

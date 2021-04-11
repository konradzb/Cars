using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.StaffDTO
{
    public record StaffDto
    {
        public static int lastId = 0;
        public int id { get; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string position { get; set; }
    }
}

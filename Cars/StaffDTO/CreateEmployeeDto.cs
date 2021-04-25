using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.StaffDTO
{
    public record CreateEmployeeDto
    {

        [Required]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [Required]
        public DateTime dateOfBirth { get; set; }
        [Required]
        public string position { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.StaffDTO;
using Cars.Model;

namespace Cars.Extensions
{
    public static class Extensions
    {
        public static EmployeeDto AsDto(this Employee staff)
        {
            return new EmployeeDto
            {
                id = staff.id,
                name = staff.name,
                surname = staff.surname,
                dateOfBirth = staff.dateOfBirth,
                position = staff.position
            };
        }
    }
}

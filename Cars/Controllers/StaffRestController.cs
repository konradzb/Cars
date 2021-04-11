using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Repositories;
using Cars.Model;
using Cars.StaffDTO;

namespace Cars.Controllers
{
    [ApiController]
    [Route("staff")]
    public class StaffRestController : ControllerBase
    {
        private readonly IStaffRepository repository;
        public StaffRestController(IStaffRepository repository)
        {
            this.repository = repository;
        }
        
        [HttpGet]
        public IEnumerable<StaffDto> GetStaff()
        {
            var staff = repository.getAllEmployees().Select(item => new StaffDto
            {
                dateOfBirth = item.dateOfBirth,
                name = item.name,
                surname = item.surname,
                position = item.position

            });
            return staff;
        }

        [HttpGet("{id}")]
        public ActionResult<Staff> GetEmployee(int id)
        {
            Staff employee = repository.getEmployeeById(id);   
            if (employee is null)
                return NotFound();
            
            return employee;
        }

    }
}

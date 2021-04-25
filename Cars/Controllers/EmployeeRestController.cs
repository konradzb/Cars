using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Repositories;
using Cars.Model;
using Cars.StaffDTO;
using Cars.Extensions;

namespace Cars.Controllers
{
    [ApiController]
    [Route("staff")]
    public class EmployeeRestController : ControllerBase
    {
        private readonly IEmployeeRepository repository;
        public EmployeeRestController(IEmployeeRepository repository)
        {
            this.repository = repository;
        }
        
        [HttpGet]
        public IEnumerable<EmployeeDto> GetStaff()
        {
            var staff = repository.getAllEmployees().Select(item => item.AsDto());
            return staff;
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            Employee employee = repository.getEmployeeById(id);   
            if (employee is null)
                return NotFound();
            
            return employee;
        }
        [HttpPost]
        public ActionResult<EmployeeDto> CreateEmployee(CreateEmployeeDto employeeDto)
        {
            Employee employee = new Employee(employeeDto.name, employeeDto.surname, employeeDto.dateOfBirth, employeeDto.position);
            repository.addEmployee(employee);

            return CreatedAtAction(nameof(GetEmployee), new { id = employee.id }, employee.AsDto());
        }
        [HttpPut("{id}")]
        public ActionResult UpdateItem(int id, UpdateEmployeeDto employeeDto)
        {
            Employee existingEmployee = repository.getEmployeeById(id);
            if(existingEmployee is null)
            {
                return NotFound();
            }
            Employee updatedEmployee = existingEmployee with
            {
                id = employeeDto.id,
                name = employeeDto.name,
                surname = employeeDto.surname,
                dateOfBirth = employeeDto.dateOfBirth,
                position = employeeDto.position
            };
            repository.editEmployeeById(updatedEmployee);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int id)
        {
            if (repository.removeEmployeeById(id))
                return NoContent();
            else
                return NotFound();
        }
    }
}
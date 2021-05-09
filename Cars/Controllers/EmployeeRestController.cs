using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Repositories;
using Cars.Model;
using Cars.Dtos;
using Cars.Extensions;
using Cars.DTOs;
using Cars.Service;
using Cars.Service.Employee;

namespace Cars.Controllers
{
    [ApiController]
    [Route("employee")]
    public class EmployeeRestController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeRestController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        
        [HttpGet]
        public IEnumerable<EmployeeDto> GetStaff()
        {
            return employeeService.GetStaff();
        }

        [HttpGet("{id}")]
        public ActionResult<EmployeeDto> GetEmployee(int id)
        {
            var employee = employeeService.GetEmployee(id);   
            if (employee is null)
                return NotFound();
            
            return employee;
        }
        [HttpPost]
        public EmployeeDto CreateEmployee(EmployeeInputDto employeeDto)
        {
            var employee = employeeService.CreateEmployee(employeeDto);
            return employee;
        }
        [HttpPut("{id}")]
        public ActionResult<EmployeeDto> UpdateItem(int id, EmployeeEditDto employeeDto)
        {

            var employee = employeeService.UpdateItem(id, employeeDto);
            if (employee == null)
                return null;

            return employee;
        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteItem(int id)
        {
            return employeeService.DeleteItem(id);
        }
    }
}
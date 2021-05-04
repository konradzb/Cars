using Cars.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Repositories;
using Cars.Extensions;

namespace Cars.Service.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeDao employeeDao;
        public EmployeeService(IEmployeeDao employeeDao)
        {
            this.employeeDao = employeeDao;
        }
        public ActionResult<EmployeeDto> CreateEmployee(EmployeeInputDto employeeDto)
        {
            int id = 0;
            Model.Employee employee = new Model.Employee(id, employeeDto.name, employeeDto.surname, employeeDto.dateOfBirth, employeeDto.position);
            return employeeDao.addEmployee(employee).AsDto();
        }

        public ActionResult<bool> DeleteItem(int id)
        {
            if (employeeDao.removeEmployeeById(id))
                return true;
            else
                return false;
        }

        public ActionResult<EmployeeDto> GetEmployee(int id)
        {
            var employee = employeeDao.getEmployeeById(id);
            if (employee is null)
                return null;

            return employee.AsDto();
        }

        public IEnumerable<EmployeeDto> GetStaff()
        {
            return employeeDao.getAllEmployees().Select(item => item.AsDto());
        }

        public ActionResult<EmployeeDto> UpdateItem(int id, EmployeeEditDto employeeDto)
        {
            var existingEmployee = employeeDao.getEmployeeById(id);
            if (existingEmployee is null)
            {
                return null;
            }

            Model.Employee updatedEmployee = existingEmployee with
            {
                id = employeeDto.id,
                name = employeeDto.name,
                surname = employeeDto.surname,
                dateOfBirth = employeeDto.dateOfBirth,
                position = employeeDto.position
            };

            return employeeDao.editEmployeeById(updatedEmployee).AsDto();
        }
    }
}

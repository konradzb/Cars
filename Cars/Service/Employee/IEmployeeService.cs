using Cars.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Service.Employee
{
    public interface IEmployeeService
    {
        EmployeeDto CreateEmployee(EmployeeInputDto employeeDto);
        ActionResult<bool> DeleteItem(int id);
        ActionResult<EmployeeDto> GetEmployee(int id);
        IEnumerable<EmployeeDto> GetStaff();
        ActionResult<EmployeeDto> UpdateItem(int id, EmployeeEditDto employeeDto);
    }
}

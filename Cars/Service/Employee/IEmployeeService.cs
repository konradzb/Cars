using Cars.DTOs;
using Cars.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Service
{
    public interface IEmployeeService
    {
        public ActionResult<bool> DeleteItem(int id);
        public ActionResult<EmployeeDto> UpdateItem(int id, EmployeeEditDto employeeDto);
        public ActionResult<EmployeeDto> CreateEmployee(EmployeeInputDto employeeDto);
        public ActionResult<EmployeeDto> GetEmployee(int id);
        public IEnumerable<EmployeeDto> GetStaff();
    }
}

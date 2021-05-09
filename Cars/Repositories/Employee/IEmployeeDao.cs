using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;

namespace Cars.Repositories
{
    public interface IEmployeeDao
    {
        List<Employee> getAllEmployees();
        Employee getEmployeeById(int id);
        Employee addEmployee(Employee employee); 
        bool removeEmployeeById(int id);
        Employee editEmployeeById(Employee employee);
        int staffLength();

    }
}

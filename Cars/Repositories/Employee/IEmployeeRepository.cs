using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;

namespace Cars.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> getAllEmployees();
        Employee getEmployeeById(int id);
        void addEmployee(Employee employee); 
        bool removeEmployeeById(int id);
        void editEmployeeById(Employee employee);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;

namespace Cars.Repositories
{
    public interface IStaffRepository
    {
        List<Staff> getAllEmployees();
        Staff getEmployeeById(int id);
        void addEmployee(Staff staff); 
        bool removeEmployeeById(int id);
        Staff editEmployeeById(int id);

    }
}

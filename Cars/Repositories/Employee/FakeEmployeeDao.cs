using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;
using Cars.Service;

namespace Cars.Repositories
{
    public class FakeEmployeeDao : IEmployeeDao
    {
        private EmployeeDummyDataGenerator generateEmployees = new EmployeeDummyDataGenerator();
        private List<Employee> staff = new List<Employee>();
        public FakeEmployeeDao()
        {
            generateEmployees.fakeEmployeeGenerator(ref staff, 3);
        }
        public Employee addEmployee(Employee employee)
        {
            this.staff.Add(employee);
            return employee;
        }

        public Employee editEmployeeById(Employee employee)
        {
            var index = staff.FindIndex(existingEmployee => existingEmployee.id == employee.id);
            staff[index] = employee;
            return staff[index];
        }

        public List<Employee> getAllEmployees()
        {
            return this.staff;
        }

        public Employee getEmployeeById(int id)
        {
            return this.staff.Find(item => item.id == id);
        }

        public bool removeEmployeeById(int id)
        {
            Employee employeeToBeDeleted = this.getEmployeeById(id);
            return this.staff.Remove(employeeToBeDeleted);
        }
    }
}

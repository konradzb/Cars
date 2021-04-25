using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;
using Cars.Service;

namespace Cars.Repositories
{
    public class FakeEmployeeRepository : IEmployeeRepository
    {
        private StaffDummyDataGenerator generateEmployees = new StaffDummyDataGenerator();
        private List<Employee> staff = new();
        public FakeEmployeeRepository()
        {
            generateEmployees.fakeEmployeeGenerator(ref staff, 3);
        }
        public void addEmployee(Employee employee)
        {
            this.staff.Add(employee);
        }

        public void editEmployeeById(Employee employee)
        {
            var index = staff.FindIndex(existingEmployee => existingEmployee.id == employee.id);
            staff[index] = employee;
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

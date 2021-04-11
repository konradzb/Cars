using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;
using Cars.Service;

namespace Cars.Repositories
{
    public class FakeStaffRepository : IStaffRepository
    {
        private StaffDummyDataGenerator generateEmployees = new StaffDummyDataGenerator();
        private List<Staff> staff = new();
        public FakeStaffRepository()
        {
            generateEmployees.fakeEmployeeGenerator(ref staff, 3);
        }
        public void addEmployee(Staff staff)
        {
            this.staff.Add(staff);
        }

        public Staff editEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Staff> getAllEmployees()
        {
            return this.staff;
        }

        public Staff getEmployeeById(int id)
        {
            return this.staff.Find(item => item.id == id);
        }

        public bool removeEmployeeById(int id)
        {
            Staff employeeToBeDeleted = this.getEmployeeById(id);
            return this.staff.Remove(employeeToBeDeleted);
        }
    }
}

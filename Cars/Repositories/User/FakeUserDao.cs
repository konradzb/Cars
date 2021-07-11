using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;
using Cars.Service;

namespace Cars.Repositories
{
    public class FakeUserDao : IUserDao
    {
        private EmployeeDummyDataGenerator generateEmployees = new EmployeeDummyDataGenerator();
        private List<User> staff = new List<User>();
        public FakeUserDao()
        {
            generateEmployees.fakeEmployeeGenerator(ref staff, 3);
        }
        public User addUser(User user)
        {
            this.staff.Add(user);
            return user;
        }

        public User editUserById(User user)
        {
            var index = staff.FindIndex(existingEmployee => existingEmployee.id == user.id);
            staff[index] = user;
            return staff[index];
        }

        public List<User> getAllUsers()
        {
            return this.staff;
        }

        public User getUserByEmail(string email)
        {
            return this.staff.Find(item => item.email == email);
        }

        public User getUserById(int id)
        {
            return this.staff.Find(item => item.id == id);
        }

        public bool removeUserById(int id)
        {
            User employeeToBeDeleted = this.getUserById(id);
            return this.staff.Remove(employeeToBeDeleted);
        }
        public int usersLength()
        {
            return this.staff.Count;
        }
    }
}

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
    public class UserService : IUserService
    {
        private readonly IUserDao userDao;
        public UserService(IUserDao userDao)
        {
            this.userDao = userDao;
        }
        public UserDto CreateUser(UserInputDto userDto)
        {
            int id = userDao.usersLength(); 
            Model.User user = new Model.User(id, userDto.name, userDto.surname, userDto.dateOfBirth, userDto.position, userDto.email, userDto.username);
            return userDao.addUser(user).AsDto();
        }

        public ActionResult<bool> DeleteUser(int id)
        {
            if (userDao.removeUserById(id))
                return true;
            else
                return false;
        }

        public ActionResult<UserDto> GetUser(int id)
        {
            var employee = userDao.getUserById(id);
            if (employee is null)
                return null;

            return employee.AsDto();
        }
        public ActionResult<UserDto> GetUserByEmail(string email)
        {
            var user = userDao.getUserByEmail(email);
            if (user is null)
                return null;
            return user.AsDto();
        }

        public IEnumerable<UserDto> GetStaff()
        {
            return userDao.getAllUsers().Select(item => item.AsDto());
        }

        public ActionResult<UserDto> UpdateUser(int id, UserEditDto userDto)
        {
            var existingEmployee = userDao.getUserById(id);
            if (existingEmployee is null)
            {
                return null;
            }

            Model.User updatedEmployee = existingEmployee with
            {
                id = userDto.id,
                name = userDto.name,
                surname = userDto.surname,
                dateOfBirth = userDto.dateOfBirth,
                position = userDto.position
            };

            return userDao.editUserById(updatedEmployee).AsDto();
        }
    }
}

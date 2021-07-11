using Cars.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Service.Employee
{
    public interface IUserService
    {
        UserDto CreateUser(UserInputDto userDto);
        ActionResult<bool> DeleteUser(int id);
        ActionResult<UserDto> GetUser(int id);
        IEnumerable<UserDto> GetStaff();
        ActionResult<UserDto> UpdateUser(int id, UserEditDto userDto);
        ActionResult<UserDto> GetUserByEmail(string email);
    }
}

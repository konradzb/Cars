using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Repositories;
using Cars.Model;
using Cars.Dtos;
using Cars.Extensions;
using Cars.DTOs;
using Cars.Service;
using Cars.Service.Employee;

namespace Cars.Controllers
{
    [ApiController]
    [Route("employee")]
    public class UserRestController : ControllerBase
    {
        private readonly IUserService userService;
        public UserRestController(IUserService userService)
        {
            this.userService = userService;
        }
        
        [HttpGet]
        public IEnumerable<UserDto> GetStaff()
        {
            return userService.GetStaff();
        }

        [HttpGet("{id}")]
        public ActionResult<UserDto> GetUser(int id)
        {
            var employee = userService.GetUser(id);   
            if (employee is null)
                return NotFound();
            
            return employee;
        }
        [HttpGet("email/{email}")]
        public ActionResult<UserDto> GetUserByEmail(string email)
        {
            var employee = userService.GetUserByEmail(email);
            if (employee is null)
                return NotFound();

            return employee;
        }

        [HttpPut("{id}")]
        public ActionResult<UserDto> UpdateUser(int id, UserEditDto userDto)
        {

            var employee = userService.UpdateUser(id, userDto);
            if (employee == null)
                return null;

            return employee;
        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteUser(int id)
        {
            return userService.DeleteUser(id);
        }

        [HttpPost]
        public ActionResult<ModelDto> CreateUser(UserInputDto userInput)
        {
            UserDto user = userService.CreateUser(userInput);
            return CreatedAtAction(nameof(GetUser), new { id = user.id }, user);
        }
    }
}
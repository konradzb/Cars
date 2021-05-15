using Cars.Configuration;
using Cars.DTOs;
using Cars.DTOs.AuthDto.Requests;
using Cars.DTOs.AuthDto.Responses;
using Cars.Service.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthManagementController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        private readonly IEmployeeService _employeeService;

        public AuthManagementController(UserManager<IdentityUser> userManager, IOptionsMonitor<JwtConfig> option, IEmployeeService employeeService)
        {
            _userManager = userManager;
            _jwtConfig = option.CurrentValue;
            _employeeService = employeeService;
        }
         
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] EmployeeInputDto employeeDto)
        {
            
            if (ModelState.IsValid)
            {
                var ifUserExisting = await _userManager.FindByEmailAsync(employeeDto.email);
                if(ifUserExisting != null)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = new List<string>()
                        {
                            "User already exists"
                        },
                        Success = false
                    });
                }
                var newUser = new IdentityUser() { Email = employeeDto.email, UserName = employeeDto.username };
                var isCreated = await _userManager.CreateAsync(newUser, employeeDto.password);
                if(isCreated.Succeeded)
                {
                    _employeeService.CreateEmployee(employeeDto);
                    var jwtToken = this.GenerateJwtToken(newUser);
                    return Ok(new RegistrationResponse()
                    {
                        Success=true,
                        Token=jwtToken
                    }); 
                } else
                {
                    this.outputError(isCreated.Errors);
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = new List<string>()
                        {
                            "Error during creating user"
                        },
                        Success = false
                    });
                }

            }
            return BadRequest(new RegistrationResponse()
            {
                Errors = new List<string>()
                        {
                            "Invalid payload register"
                        },
                Success = false
            });
        }
        private void outputError(IEnumerable<IdentityError> err)
        {
            foreach(var msg in err)
            {
                Console.WriteLine(msg);
            }
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)
        {
            if(ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.email);
                if(existingUser == null)
                {
                    return BadRequest(new RegistrationResponse() { 
                        Errors = new List<string>()
                        {
                            "Invalid login request"
                        },
                        Success = false
                    });

                }
   
                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.password);
                if (!isCorrect)
                {
                    return BadRequest();
                }
                var jwtToken = GenerateJwtToken(existingUser);
                return Ok(new RegistrationResponse()
                {
                    Success = true,
                    Token = jwtToken
                });
            }
            return BadRequest(new RegistrationResponse()
            {
                Errors = new List<string>()
                        {
                            "Invalid login request"
                        },
                Success = false
            });
        }
        private string GenerateJwtToken(IdentityUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };
            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);
            return jwtToken;
        }
    }
}

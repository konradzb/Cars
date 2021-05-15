using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.DTOs.AuthDto.Requests
{
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

    }
}

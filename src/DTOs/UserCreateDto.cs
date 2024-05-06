using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs;

    public class UserCreateDto
    {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
 
    }

// id of entity will be automatically generated in database 
// when we want to create user (register), we only need their name, email, password 
// create http => controller UserCreateDTO 
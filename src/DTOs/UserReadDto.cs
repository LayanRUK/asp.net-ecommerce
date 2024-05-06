using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs;

public class UserReadDto
{


    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";

    public UserReadDto(string id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }


}

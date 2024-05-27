using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;
namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs;
public class UserUpdateDto
{
    public string? Name { get; set; }
    public string? Email { get; set; }
}
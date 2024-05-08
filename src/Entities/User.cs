

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;

[Index(nameof(Email), IsUnique = true)]
public class User
{
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required, EmailAddress]

    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    public IEnumerable<Order> Orders { get; set; }
    [Required]
    public Role role { get; set; } = Role.Customer;
}





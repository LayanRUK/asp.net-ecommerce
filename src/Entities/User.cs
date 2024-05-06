

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;

//  [Index(nameof(Email), IsUnique = true)] 
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        [Required]
        public string Name { get; }  
        [Required, EmailAddress]
        public string Email { get; }
        [Required]
        public string Password { get; set; }
        [Required]   
        public Role Role { get; set; } = Role.customer;

        public User(string name, string email, string password)
        {

            Name = name;
            Email = email;
            Password = password;
        }

    }

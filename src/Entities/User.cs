

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }
        public string Email { get; }
        public string Password { get; set; }


        public User(string name, string email, string password)
        {

            Name = name;
            Email = email;
            Password = password;
        }

    }
}
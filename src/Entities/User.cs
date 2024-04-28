

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class User
    {
        private string _id { get; set; }
        private string? _name { get; set; }
        private string? _email { get; set; }
        private string? _password { get; set; }

        public User(string id, string name, string email, string password)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
        }
    }
}
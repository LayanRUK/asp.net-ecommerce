


using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext
    {
        List<User> users;

        public DatabaseContext(string id, string name, string email, string password)
        {
            users = [

            new User ("1","sarah","sarah@gmail.com ", "sarah1"),

            new User ("2","lama","lama@gmail.com ", "lama2"),

            new User ("3","layan","layan@gmail.com ", "layan3"),

            ];

        }
    }
}
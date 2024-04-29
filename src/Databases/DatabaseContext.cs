


using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext
    {
        public IEnumerable<User> users {get; set;}

        public DatabaseContext()
        {
            users = [

            new User ("1","sarah","sarah@gmail.com ", "sarah1"),

            new User ("2","lama","lama@gmail.com ", "lama2"),

            new User ("3","layan","layan@gmail.com ", "layan3"),

            ];

        }
    }
}
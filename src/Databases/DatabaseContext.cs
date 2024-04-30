


using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext
    {
        public IEnumerable<User> users { get; set; }

        public DatabaseContext()
        {
            users = [

            new User ("sarah","sarah@gmail.com ", "sarah1"),

            new User ("lama","lama@gmail.com ", "lama2"),

            new User ("layan","layan@gmail.com ", "layan3"),

            ];

        }
    }
}
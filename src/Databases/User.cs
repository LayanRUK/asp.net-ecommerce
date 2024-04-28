using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class User
    {
        List<User>? users;

        public User(string id, string name, string email, string password)
        {
            users = [

            new User ("1","sarah","sarah@gmail.com ", "sarah1"),

            new User ("2","lama","lama@gmail.com ", "lama2"),

            new User ("3","layan","layan@gmail.com ", "layan3"),

            ];

        }
    }
}
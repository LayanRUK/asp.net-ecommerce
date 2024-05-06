using System.Collections.Generic;

using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

using Microsoft.EntityFrameworkCore;

using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Services;


namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{

    public class DatabaseContext : DbContext

    {

        public IEnumerable<Order> orders { get; set; }
        public IEnumerable<Product> products;
        public List<User> users { get; set; }
=======
        public DbSet<Order> orders { get; set; }
        public DbSet<Order_Item> orderItems { get; set; }
        public DbSet<Product> products;
        public IEnumerable<User> users { get; set; }

        private IConfiguration _config;

        public DatabaseContext()
        {
            users = [

              new User ("sarah","sarah@gmail.com ", "sarah1"),

            new User("lama","lama@gmail.com ", "lama2"),


            new User ("lama","lama@gmail.com ", "lama2"),

            new User ("layan","layan@gmail.com ", "layan3"),
            ];
        }
        public DatabaseContext(IConfiguration config)
        {
            _config = config;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Database={_config["Db:Database"]};Password={_config["Db:Password"]}")
           .UseSnakeCaseNamingConvention();
        }

    }

}



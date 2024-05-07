using System.Collections.Generic;


using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

using Microsoft.EntityFrameworkCore;

using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Services;


namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;


    public class DatabaseContext : DbContext
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products {get; set;}
        public DbSet<User> Users { get; set; }


        private IConfiguration _config;

        public DatabaseContext(DbContextOptions options,  IConfiguration config) : base(options)
        {
            _config = config;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Password={_config["Db:Password"]};Database={_config["Db:Database"]}")
           .UseSnakeCaseNamingConvention();
        }

    
    }





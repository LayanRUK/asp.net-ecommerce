using System.Collections.Generic;


using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

using Microsoft.EntityFrameworkCore;

using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Services;
using Npgsql;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;


namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;


    public class DatabaseContext : DbContext
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products {get; set;}
        public DbSet<User> Users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }


protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<Role>();
    }
    }



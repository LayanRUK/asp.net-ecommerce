using System.Collections.Generic;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Services;


namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;


    public class DatabaseContext

    {
        public IEnumerable<Order> orders { get; set; }
        public IEnumerable<Product> products;
        public IEnumerable<User> users { get; set; }

        public DatabaseContext()
        {
            orders = [
            new Order("1","123","132",0506636619,"67"),
        ];
           
        products = new List<Product>
        {
            new Product( "Product1", 200 , 1, " "),
            new Product( "Product2", 200 , 2," ")
        };


        users = [

          new User ("sarah","sarah@gmail.com ", "sarah1"),

            new User ("lama","lama@gmail.com ", "lama2"),
            new User ("layan","layan@gmail.com ", "layan3"),
            ];
            
      

    }}

    

        
    



using System.Collections.Generic;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
   public class DatabaseContext
{
    public IEnumerable<Product> products; 
    public DatabaseContext()
    {
        products = new List<Product>
        {
            new Product( "Product1", 200 , 1, " "),
            new Product( "Product2", 200 , 2," ")
        };
    }
}
}
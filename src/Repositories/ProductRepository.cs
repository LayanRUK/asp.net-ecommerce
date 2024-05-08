using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

using sda_onsite_2_csharp_backend_teamwork.src.Databases;


// using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class ProductRepository : IProductRepository
{
  private DbSet<Product> _products { get; set; }
  private DatabaseContext _databaseContext;
  public ProductRepository(DatabaseContext databaseContext)

  {
    _databaseContext = databaseContext;
    _products = _databaseContext.Products;
  }

  public IEnumerable<Product> GetAll()
  {
    return _products;
  }


  public Product CreateOne(Product product)
  {

    _products.Add(product);
    _databaseContext.SaveChanges();

    return product;
  }



  // public IEnumerable<Product> DeleteOne(Guid id)
  // {
  //   // find item is exist or not , if yes, you will have foundItem 
  //   // Remove() _products.Remove(foundItem)
  // _products.Where(u => u.Id != id);
  //   return _products;
  // }



  public Product FindOne(string name)
  {
    return _products.FirstOrDefault(P => P.Name == name);

  }

}

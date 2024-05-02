using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class ProductRepository : IProductRepository
{
  private IEnumerable<Product> _products { get; set; }
  private DatabaseContext _databaseContext;
  public ProductRepository()
  {
    _databaseContext = new DatabaseContext();
    _products = _databaseContext.products;
  }
  public IEnumerable<Product> GetAll()
  {
    return _products;
  }
  public IEnumerable<Product> CreateOne(Product product)
  {
    return _products.Append(product);
  }
  public IEnumerable<Product> DeleteOne(Guid id)
  {
    _products = _products.Where(u => u.Id != id);
    return _products;
  }
  public IEnumerable<Product> FindOne(Guid id)
  {
    _products = _products.Where(u => u.Id != id);
    return _products;
  }

}

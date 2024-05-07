using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_sharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
public interface IProductService
{
  public List<ProductReadDto> GetAll();

  public Product CreateOne(ProductCreateDto product);
  // public IEnumerable<Product> DeleteOne(Guid id);
  public ProductReadDto FindOne(string name);

}



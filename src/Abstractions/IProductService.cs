using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_sharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
public interface IProductService
{
  // public List<ProductReadDto> GetAll();
  public List<ProductReadDto> GetAll( GetAllOptions getAllOptions);

  public Product CreateOne(ProductCreateDto product);


  // public IEnumerable<Product> DeleteOne(Guid id);
  public ProductReadDto FindOne(string name);

public ActionResult  <bool> DeleteOne(string name );


 public  bool UpdateOne(string name, ProductUpdateDto updateDto);

// public IEnumerable<ProductReadDto> FindAll(int limit, int offset);


}



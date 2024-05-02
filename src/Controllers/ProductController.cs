using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{
  public class ProductController : BaseController
  {
    private IProductService _productService;
    public ProductController(IProductService productService)
    {
      _productService = productService;
    }



    [HttpGet]
    public IEnumerable<Product> GetAll()
    {
      return _productService.GetAll();

    }
    [HttpPost]
    public IEnumerable<Product> CreateOne(Product product)
    {
      return _productService.CreateOne(product);

    }
    [HttpDelete("{id}")]
    public IEnumerable<Product> DeleteOne(Guid id)
    {
      return _productService.DeleteOne(id);

    }
    [HttpGet("{id}")]
    public IEnumerable<Product> FindOne(Guid id)
    {
      return _productService.FindOne(id);


    }
  }
}
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_sharp_backend_teamwork.src.DTOs;
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
    public List<ProductReadDto> GetAll()
    {
      return _productService.GetAll();

    }


    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Product> CreateOne([FromBody] ProductCreateDto product)
    {

      if (product is not null)
      {
        var createdproduct = _productService.CreateOne(product);
        return CreatedAtAction(nameof(CreateOne), product);
      }
      return BadRequest();

    }

    // [HttpDelete("{id}")]
    // public IEnumerable<Product> DeleteOne(Guid id)
    // {
    //   return _productService.DeleteOne(id);

    // }



    [HttpGet("{email}")]
    public ProductReadDto FindOne(string email)
    {
      return _productService.FindOne(email);
    }

  }
}
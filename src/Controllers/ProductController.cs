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


    // [HttpGet]
    // public List<ProductReadDto> GetAll()
    // {
    //   return _productService.GetAll();

    // }
[HttpGet]
    public List<ProductReadDto> GetAll ( [FromQuery] GetAllOptions getAllOptions )
    {
      return _productService.GetAll(getAllOptions);
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

[HttpDelete("{name}")]
        public  ActionResult<bool> DeleteOne([FromRoute] string name)
        {
            var deleted =  _productService.DeleteOne(name);
            return Ok(deleted);
        }

    [HttpGet("{name}")]
    public ProductReadDto FindOne(string name)
    {
      return _productService.FindOne(name);
    }

    [HttpPatch("{name}")]
        public ActionResult<bool> UpdateOne([FromRoute] string name , [FromBody] ProductUpdateDto updateDto)
        {
            var updated =  _productService.UpdateOne (name, updateDto);
            return Ok(updated);
        }
    //     [HttpGet]
    // [ProducesResponseType(StatusCodes.Status200OK)]
    // [ProducesResponseType(StatusCodes.Status500InternalServerError)]

    // public ActionResult<IEnumerable<ProductReadDto>> FindAll([FromQuery(Name = "searchBy")] string searchBy)
    // {
    //     return Ok(_productService.FindAll());
    // }

  }
}
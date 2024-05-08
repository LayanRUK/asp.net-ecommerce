using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

public class OrderItemController : BaseController
{

    public IOrderItemService _order_ItemService;
    public OrderItemController(IOrderItemService orderItemService)
    {
        _order_ItemService = orderItemService;
    }
    [HttpGet]
    public List<OrderItemReadDto> GetAll()
    {
        return _order_ItemService.GetAll();
    }

    [HttpPost]

    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItem> CreateOne([FromBody] OrderItemCreateDto order_item)
    {

        if (order_item is not null)
        {
            var createdorderItem = _order_ItemService.CreateOne(order_item);
            return CreatedAtAction(nameof(CreateOne), order_item);
        }

        return BadRequest();
    }



    // [HttpDelete("{id}")]

    // public IEnumerable<OrderItem> DeleteOne(Guid id)
    // {
    //     return _order_ItemService.DeleteOne(id);
    // }

    [HttpGet("{id}")]

    public OrderItemReadDto FindOne(Guid id)
    {
        return _order_ItemService.FindOne(id);
    }

}
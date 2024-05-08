using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class OrderController : BaseController
{

    private IOrderService _orderService;
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public List<OrderReadDto> GetAll()
    {
        return _orderService.GetAll();
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public ActionResult<Order> CreateOne([FromBody] OrderCreatDto order)
    {

        if (order is not null)
        {
            var createdorder = _orderService.CreateOne(order);
            return CreatedAtAction(nameof(CreateOne), order);
        }
        return BadRequest();

    }
    // [HttpDelete("{id}")]
    // public IEnumerable<Order> DeleteOne(Guid id)
    // {
    //     return _orderService.DeleteOne(id);
    // }
    [HttpGet("{id}")]
    public OrderReadDto FindOne(Guid id)
    {

        return _orderService.FindOne(id);
    }

    [HttpPost("checkout")]

    public Order Checkout(List<OrderItemCreateDto> orderItemCreateDtos)
    {
        return _orderService.Checkout(orderItemCreateDtos);
    }

}
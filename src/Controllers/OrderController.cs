using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class OrderController : BaseController
{

    public IOrderService _orderService;
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IEnumerable<Order> GetAll()
    {
        return _orderService.GetAll();
    }
    [HttpPost]
    public IEnumerable<Order> CreateOne(Order order)
    {
        return _orderService.CreateOne(order);

    }
    [HttpDelete("{id}")]
    public IEnumerable<Order> DeleteOne(Guid id)
    {
        return _orderService.DeleteOne(id);
    }
    [HttpGet("{id}")]
    public IEnumerable<Order> FindOne(Guid id)
    {

        return _orderService.FindOne(id);
    }

    [HttpPost("/checkout")]

    public Order Checkout(List<OrderItemCreateDto> orderItemCreateDtos)
    {
        return _orderService.Checkout(orderItemCreateDtos);
    }

}
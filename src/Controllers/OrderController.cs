using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
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
 
    [HttpGet("{id}")]
    public OrderReadDto FindOne(Guid id)
    {

        return _orderService.FindOne(id);
    }

    [Authorize(Roles = "Admin,Customer")]
    [HttpPost("checkout")]
    public Order Checkout(List<OrderItemCreateDto> orderItemCreateDtos)
    {
        string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        return _orderService.Checkout(orderItemCreateDtos, userId);
    }

}
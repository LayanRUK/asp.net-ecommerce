using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public class OrderItemController : BaseController
{

    public IOrderItemService _order_ItemService;
    public OrderItemController(IOrderItemService orderItemService)
    {
        _order_ItemService = orderItemService;
    }
    [HttpGet]
    public IEnumerable<OrderItem> GetAll()
    {
        return _order_ItemService.GetAll();
    }

    [HttpPost]
    public IEnumerable<OrderItem> CreateOne(OrderItem order_item)
    {
        return _order_ItemService.CreateOne(order_item);
    }

    [HttpDelete("{id}")]

    public IEnumerable<OrderItem> DeleteOne(Guid id)
    {
        return _order_ItemService.DeleteOne(id);
    }

    [HttpGet("{id}")]

    public IEnumerable<OrderItem> FindOne(Guid id)
    {
        return _order_ItemService.FindOne(id);
    }

}
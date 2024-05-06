using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public class Order_ItemController : BaseController
{

    public IOrder_ItemService _order_ItemService;
    public Order_ItemController(IOrder_ItemService orderItemService)
    {
        _order_ItemService = orderItemService;
    }
    [HttpGet]
    public IEnumerable<Order_Item> GetAll()
    {
        return _order_ItemService.GetAll();
    }

    [HttpPost]
    public IEnumerable<Order_Item> CreateOne(Order_Item order_item)
    {
        return _order_ItemService.CreateOne(order_item);
    }

    [HttpDelete("{id}")]

    public IEnumerable<Order_Item> DeleteOne(Guid id)
    {
        return _order_ItemService.DeleteOne(id);
    }

    [HttpGet("{id}")]

    public IEnumerable<Order_Item> FindOne(Guid id)
    {
        return _order_ItemService.FindOne(id);
    }

}
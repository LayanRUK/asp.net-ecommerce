using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class OrderService : IOrderService
{

    private IOrderRepository _orderRepository;
    private IOrderItemRepository _orderItemRepository;

    public OrderService(IOrderRepository orderRepository, IOrderItemRepository orderItemRepository )
    {
        _orderRepository = orderRepository;
        _orderItemRepository = orderItemRepository; 
    }
    public IEnumerable<Order> GetAll()
    {
        return _orderRepository.GetAll();
    }

    public IEnumerable<Order> CreateOne(Order order)
    {
        return _orderRepository.CreateOne(order);

    }

    public IEnumerable<Order> DeleteOne(Guid id)
    {
        return _orderRepository.DeleteOne(id);
    }

    public IEnumerable<Order> FindOne(Guid id)
    {

        return _orderRepository.FindOne(id);
    }

    public Order Checkout(List<OrderItemCreateDto> orderItemCreateDtos)
    {
        // create an order 
        var order = new Order(); 
        // for loop in the list of order item create Dto 
        foreach(var item in orderItemCreateDtos)
        {
            var orderItem = new OrderItem(); 
            orderItem.OrderId = order.Id; 
            orderItem.ProductId = item.ProductId;
            orderItem.Price = item.Price; 
            orderItem.Quantity = item.Quantity; 
            _orderItemRepository.CreteOne(orderItem); 
        }
        order.UserId = Guid.NewGuid();
        // save order in order table 
        _orderRepository.CreateOne(order); 
        return order; 
    }
    //Add Check for Prodect and the quantity.
}
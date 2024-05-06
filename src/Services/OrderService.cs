using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class OrderService : IOrderService
{

    private IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
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


}
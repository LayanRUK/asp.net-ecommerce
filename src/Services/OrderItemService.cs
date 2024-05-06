using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public class OrderItemService : IOrderItemService
{

    private IOrderItemRepository _order_itemRepository;

    public OrderItemService(IOrderItemRepository orderitemRepository)
    {
        _order_itemRepository = orderitemRepository;
    }

    public IEnumerable<OrderItem> GetAll()
    {

        return _order_itemRepository.GetAll();
    }
    public IEnumerable<OrderItem> CreateOne(OrderItem order_item)
    {

        return _order_itemRepository.CreteOne(order_item);
    }

    public IEnumerable<OrderItem> DeleteOne(Guid id)
    {

        return _order_itemRepository.DeleteOne(id);
    }

    public IEnumerable<OrderItem> FindOne(Guid id)
    {

        return _order_itemRepository.FindOne(id);
    }


}


using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public class _order_ItemService : IOrder_ItemService
{

    private IOrder_ItemRepository _order_itemRepository;

    public _order_ItemService(IOrder_ItemRepository orderitemRepository)
    {
        _order_itemRepository = orderitemRepository;
    }

    public IEnumerable<Order_Item> GetAll()
    {

        return _order_itemRepository.GetAll();
    }
    public IEnumerable<Order_Item> CreateOne(Order_Item order_item)
    {

        return _order_itemRepository.CreteOne(order_item);
    }

    public IEnumerable<Order_Item> DeleteOne(Guid id)
    {

        return _order_itemRepository.DeleteOne(id);
    }

    public IEnumerable<Order_Item> FindOne(Guid id)
    {

        return _order_itemRepository.FindOne(id);
    }


}


using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;


namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class Order_ItemRepository : IOrder_ItemRepository
{

    private IEnumerable<Order_Item> _order_items { get; set; }
    private DatabaseContext _databaseContext;

    public Order_ItemRepository()
    {
        _databaseContext = new DatabaseContext();
        _order_items = _databaseContext.Order_Items;
    }
    public IEnumerable<Order_Item> GetAll()
    {
        return _order_items;
    }

    public IEnumerable<Order_Item> CreteOne(Order_Item order_item)
    {
        return _order_items.Append(order_item);

    }

    public IEnumerable<Order_Item> DeleteOne(Guid id)
    {
        _order_items = _order_items.Where(u => u.Id != id);

        return _order_items;

    }

    public IEnumerable<Order_Item> FindOne(Guid id)
    {
        _order_items = _order_items.Where(u => u.Id != id);

        return _order_items;

    }

}
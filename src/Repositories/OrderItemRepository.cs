using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;


namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class OrderItemRepository : IOrderItemRepository
{

    private DbSet<OrderItem> _orderItems; 
    private DatabaseContext _databaseContext;

    public OrderItemRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _orderItems = databaseContext.OrderItems;
    }
    public IEnumerable<OrderItem> GetAll()
    {
        return _orderItems;
    }

    public IEnumerable<OrderItem> CreteOne(OrderItem order_item)
    {
        return _orderItems.Append(order_item);

    }

    public IEnumerable<OrderItem> DeleteOne(Guid id)
    {
        _orderItems.Where(u => u.Id != id);

        return _orderItems;

    }

    public IEnumerable<OrderItem> FindOne(Guid id)
    {
        _orderItems.Where(u => u.Id != id);

        return _orderItems;

    }

}
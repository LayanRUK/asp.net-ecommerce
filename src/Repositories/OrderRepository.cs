using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;


namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class OrderRepository : IOrderRepository
{

    private IEnumerable<Order> _orders { get; set; }
    private DatabaseContext _databaseContext;



    public OrderRepository()
    {
        _databaseContext = new DatabaseContext();
        _orders = _databaseContext.orders;

    }

    public IEnumerable<Order> GetAll()
    {
        return _orders;
    }

    public IEnumerable<Order> CreateOne(Order order)
    {
        return _orders.Append(order);


    }
    public IEnumerable<Order> DeleteOne(Guid id)
    {
        _orders = _orders.Where(u => u.Id != id);
        return _orders;
    }

    public IEnumerable<Order> FindOne(Guid id)
    {
        _orders = _orders.Where(u => u.Id != id);
        return _orders;
    }


}
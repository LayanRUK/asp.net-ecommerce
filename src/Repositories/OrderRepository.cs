using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;


namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class OrderRepository : IOrderRepository
{

    private DbSet<Order> _orders { get; set; }
    private DatabaseContext _databaseContext;



    public OrderRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _orders = databaseContext.Orders;

    }

    public IEnumerable<Order> GetAll()
    {
        return _orders;
    }

    public Order CreateOne(Order order)
    {
         _orders.Add(order);
         _databaseContext.SaveChanges();
         return order; 

    }
    // public IEnumerable<Order> DeleteOne(Guid id)
    // {
    //     _orders.Where(u => u.Id != id);
    //     return _orders;
    // }

    public Order FindOne(Guid id)
    {
      return _orders.FirstOrDefault(O=> O.Id == id);
    }


}

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;


public interface IOrderItemService
{
    public IEnumerable<OrderItem> GetAll();
    public IEnumerable<OrderItem> CreateOne(OrderItem order_item);

    public IEnumerable<OrderItem> DeleteOne(Guid id);

    public IEnumerable<OrderItem> FindOne(Guid id);
}




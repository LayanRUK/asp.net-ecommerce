

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
public interface IOrderItemRepository
{
    public IEnumerable<OrderItem> GetAll();
    public OrderItem CreteOne(OrderItem order_item);

    // public IEnumerable<OrderItem> DeleteOne(Guid id);
    public OrderItem FindOne(Guid id);

}
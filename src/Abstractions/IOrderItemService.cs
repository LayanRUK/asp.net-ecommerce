
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;


public interface IOrderItemService
{
    public List<OrderItemReadDto> GetAll();
    public OrderItem CreateOne(OrderItemCreateDto order_item);

    // public IEnumerable<OrderItem> DeleteOne(Guid id);

    public OrderItemReadDto FindOne(Guid id);
}




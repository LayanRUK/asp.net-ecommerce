
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;


public interface IOrderService
{
    public List <OrderReadDto> GetAll();
    public Order CreateOne(OrderCreatDto order);

    // public IEnumerable<Order> DeleteOne(Guid id);

    public  OrderReadDto FindOne(Guid id);

      public Order Checkout(List<OrderItemCreateDto> orderItemCreateDtos);
}




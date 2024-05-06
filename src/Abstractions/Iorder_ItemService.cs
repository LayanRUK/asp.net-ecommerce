
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;


public interface IOrder_ItemService
{
    public IEnumerable<Order_Item> GetAll();
    public IEnumerable<Order_Item> CreateOne(Order_Item order_item);

    public IEnumerable<Order_Item> DeleteOne(Guid id);

    public IEnumerable<Order_Item> FindOne(Guid id);
}




public interface IOrder_ItemRepository
{

    public IEnumerable<Order_Item> GetAll();


    public IEnumerable<Order_Item> CreteOne(Order_Item order_item);

    public IEnumerable<Order_Item> DeleteOne(Guid id);

    public IEnumerable<Order_Item> FindOne(Guid id);

}
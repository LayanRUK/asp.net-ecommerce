public interface IOrderItemRepository
{

    public IEnumerable<OrderItem> GetAll();

    public IEnumerable<OrderItem> CreteOne(OrderItem order_item);

    public IEnumerable<OrderItem> DeleteOne(Guid id);

    public IEnumerable<OrderItem> FindOne(Guid id);

}
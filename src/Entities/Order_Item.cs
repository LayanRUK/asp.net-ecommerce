public class Order_Item
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Stock_id { get; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public int Order_Id { get; set; }

    public Order_Item(string stock_id, double price, int quantity, int order_Id)
    {

        Stock_id = stock_id;
        Price = price;
        Quantity = quantity;
        Order_Id = order_Id;

    }
}
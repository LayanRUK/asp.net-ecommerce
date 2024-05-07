using System.ComponentModel.DataAnnotations.Schema;

public class OrderItem
{
    public Guid Id { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
}
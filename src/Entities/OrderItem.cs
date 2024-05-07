using System.ComponentModel.DataAnnotations.Schema;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class OrderItem
{
    public Guid Id { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Guid ProductId { get; set; }
    public Guid OrderId { get; set; }

    public Product Product { get; set; }
    public Order Order { get; set; }
}
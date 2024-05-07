using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;
public class Order
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public int PhoneNumber { get; set; }
    public IEnumerable<OrderItem> OrderItems { get; set; }

}
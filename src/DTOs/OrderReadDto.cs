using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class OrderReadDto
    {
         public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public IEnumerable<OrderItem> OrderItems { get; set; } 
    }
}
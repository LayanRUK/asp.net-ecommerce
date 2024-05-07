using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;
public class Order
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public IEnumerable<OrderItem> OrderItems { get; set; }

}


// when you want to create an Order, you need to have a list of createOrderItemDTO    (Done )

// createOrderItemDTO  (Done)

//  public double Price { get; set; }
//     public int Quantity { get; set; }

//     public Guid ProductId { get; set; }

// inside orderservice
// Initialise a new order . var order = new Order() 
// for loop list of createOrderItemDTO
// var orderItem = new OrderItem() 
// find ProductId exist or not 
// orderItem.OrderId = order.id 
// ..
// OrderItemRepo.CreateOne(orderItem)

// outside for loop 
// OrderRepo.CreateOne(order)


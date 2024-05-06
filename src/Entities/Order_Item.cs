using System.ComponentModel.DataAnnotations.Schema;

public class Order_Item
{
    public Guid Id { get; set; }
    public string Stock_id { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public int Order_Id { get; set; }


}
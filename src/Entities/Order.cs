public class Order
{
    public Guid Id { get; } = Guid.NewGuid();
    public string User_id { get; }
    public string Created_at { get; set; }
    public string Address_id { get; set; }
    public int Phone_number { get; set; }
    public string Payment_id { get; set; }

    public Order(string user_id, string created_at, string address_id, int phone_number, string payment_id)
    {

        User_id = user_id;
        Created_at = created_at;
        Address_id = address_id;
        Phone_number = phone_number;
        Payment_id = payment_id;
    }
}
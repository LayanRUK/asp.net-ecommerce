public class DatabaseContext
{

    public IEnumerable<Order> orders { get; set; }


    public DatabaseContext()
    {
        orders = [
new Order("1","123","132",0506636619,"67"),

        ];




    }
}
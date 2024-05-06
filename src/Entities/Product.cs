namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Product
    {
        public Guid Id { get; set;}
        public string Name { get; set; }
        public int Price { get; set; }
        public int Category_id { get; set; }
        public string Image { get; set; }
    }

}
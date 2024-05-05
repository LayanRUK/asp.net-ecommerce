namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Product
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Price { get; set; }
        public int Category_id { get; set; }
        public string Image { get; set; }
        public Product(string name, int price, int category_id, string image)
        {

            Name = name;
            Price = price;
            Category_id = category_id;
            Image = image;

        }
    }

}
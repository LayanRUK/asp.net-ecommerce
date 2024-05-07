using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IProductRepository
{
    public IEnumerable<Product> GetAll();

    public Product CreateOne(Product product);

    // public IEnumerable<Product> DeleteOne(Guid id);

    public Product FindOne(string name);



}

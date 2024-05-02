using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services{

    public class ProductService: IProductService
   {
    private IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository)
    {
        _productRepository= productRepository;
    }
    public IEnumerable<Product> GetAll(){
        return  _productRepository.GetAll();
    }

   public IEnumerable<Product> CreateOne(Product product){
        return  _productRepository.CreateOne(product);
    }
    public IEnumerable<Product> DeleteOne(Guid id){
        return  _productRepository.DeleteOne(id);
    }
      public IEnumerable<Product> FindOne(Guid id){
        return  _productRepository.FindOne(id);
    }

   }}
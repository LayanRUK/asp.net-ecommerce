using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_sharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{

    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {

            _productRepository = productRepository;
            _mapper = mapper;
        }





        public List<ProductReadDto> GetAll()
        {
            var products = _productRepository.GetAll();
            var productRead = products.Select(_mapper.Map<ProductReadDto>);
            return productRead.ToList();
 
        }

        public Product CreateOne(ProductCreateDto productCreateDto)
        {
            var product = _mapper.Map<Product>(productCreateDto);

            return _productRepository.CreateOne(product);
        }

        // }
        // public IEnumerable<Product> DeleteOne(Guid id)
        // {
        //     return _productRepository.DeleteOne(id);
        // }

        public ProductReadDto FindOne(string name)
        {
            var product = _productRepository.FindOne(name);
            var productRead = _mapper.Map<ProductReadDto>(product);
            return productRead;
        }

    }
}
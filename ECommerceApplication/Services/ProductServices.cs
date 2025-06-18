using ECommerceApplication.Models;
using ECommerceApplication.Repository.Interfaces;
using ECommerceApplication.Services.Interfaces;

namespace ECommerceApplication.Services
{
    public class ProductServices:IProductService
    {
        List<Product> products = new List<Product>();
        private readonly IProductRepository _productRepository;

        public ProductServices(IProductRepository repo)
        {
            _productRepository = repo;
        }

        
        public List<Product> getAllProduct()
        {
            products = _productRepository.getAllProduct();
            return products;
        }

        public bool addProduct()
        {
            throw new NotImplementedException();
        }

        public bool deleteProduct()
        {
            throw new NotImplementedException();
        }

      
        public Product getProductById()
        {
            throw new NotImplementedException();
        }

        public Product getProductByTitle()
        {
            throw new NotImplementedException();
        }

        public bool updateProduct()
        {
            throw new NotImplementedException();
        }
    }
}
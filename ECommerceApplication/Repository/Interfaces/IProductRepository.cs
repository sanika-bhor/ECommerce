using ECommerceApplication.Models;

namespace ECommerceApplication.Repository.Interfaces
{
    public interface IProductRepository
    {
        List<Product> getAllProduct();
        Product getProductById();
        Product getProductByTitle();
        bool addProduct();
        bool updateProduct();
        bool deleteProduct();
    }
}
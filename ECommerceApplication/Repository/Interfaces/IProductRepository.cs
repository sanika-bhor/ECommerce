using ECommerceApplication.Models;

namespace ECommerceApplication.Repository.Interfaces
{
    public interface IProductRepository
    {
        List<Product> getAllProduct();
        Product getProductById(int id);
        Product getProductByTitle(string title);
        bool addProduct(Product product);
        bool updateProduct(Product product);
        bool deleteProduct(int id);
    }
}
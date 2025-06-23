using ECommerceApplication.Models;

namespace ECommerceApplication.Repository.Interfaces
{
    public interface IShoppingCartRepository
    {
        List<Item> getAllItem();
        Item getItemById(int id);
        List<Product> getItemByCategoryId(int id);
        Product getItemByTitle(string title);
        bool addItem(Product product);
        bool updateItem(Product product);
        bool deleteItem(int id);
    }
}
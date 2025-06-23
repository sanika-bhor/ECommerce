using ECommerceApplication.Models;

namespace ECommerceApplication.Repository.Interfaces
{
    public interface IShoppingCartRepository
    {
        List<Item> getAllItem();
        Item getItemById(int id);
        List<Product> getItemByCategoryId(int id);
        Product getItemByTitle(string title);
        bool addItem(Item item);
        bool updateItem(Item item);
        bool deleteItem(int id);
    }
}
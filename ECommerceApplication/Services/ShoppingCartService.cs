using ECommerceApplication.Models;
using ECommerceApplication.Repository.Interfaces;
using ECommerceApplication.Services.Interfaces;

namespace ECommerceApplication.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _cartService;
        public bool addItem(Item item)
        {
            bool Status = false;
            Status = _cartService.addItem(item);
            return Status;
        }

        public bool deleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Item> getAllItem()
        {
            List<Item> items = _cartService.getAllItem();
            return items;
        }

        public List<Product> getItemByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public Item getItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Product getItemByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public bool updateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
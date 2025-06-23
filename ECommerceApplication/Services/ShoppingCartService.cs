using ECommerceApplication.Models;
using ECommerceApplication.Repository.Interfaces;
using ECommerceApplication.Services.Interfaces;

namespace ECommerceApplication.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _cartrepo;
        public ShoppingCartService(IShoppingCartRepository repo)
        {
            _cartrepo = repo;
        }
        public bool addItem(Item item)
        {
            bool Status = false;
            Status = _cartrepo.addItem(item);
            return Status;
        }

        public bool deleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Item> getAllItem()
        {
            List<Item> items = new List<Item>();
            items = (List<Item>)_cartrepo.getAllItem();
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
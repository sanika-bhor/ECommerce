using System.Data;
using ECommerceApplication.Models;
using ECommerceApplication.Utils;
using MySql.Data.MySqlClient;

namespace ECommerceApplication.Repository.Interfaces
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public bool addItem(Product product)
        {
            throw new NotImplementedException();
        }

        public bool deleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Item> getAllItem()
        {
            List<Item> items = new List<Item>();
            // implement logic to get all items from database
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            string query = "select * from cart";
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
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

        public bool updateItem(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
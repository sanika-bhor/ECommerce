using System.Data;
using ECommerceApplication.Models;
using ECommerceApplication.Utils;
using MySql.Data.MySqlClient;

namespace ECommerceApplication.Repository.Interfaces
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public bool addItem(Item item)
        {
            bool Status=false;

            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = conn.CreateCommand();
            string query= "insert into cart(ItemName, ItemImage,Qunatity,UnitPrice,product_id) values(@itemName,@itemImage,@quantity,@unitPrice,@productId)";
            cmd.Parameters.Add(new MySqlParameter("@itemName", item.product.ProductTitle));
            cmd.Parameters.Add(new MySqlParameter("@itemImage", item.product.ProductImage));
            cmd.Parameters.Add(new MySqlParameter("@quantity", item.Quantity));
            cmd.Parameters.Add(new MySqlParameter("@unitPrice", item.product.UnitPrice));
            cmd.Parameters.Add(new MySqlParameter("@productId", item.product.ProductId));

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return Status;
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
            IDataReader reader = null;

            string query = "select * from cart";
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ItemId"].ToString());
                    string name = reader["ItemName"].ToString();
                    string image = reader["ItemImage"].ToString();
                    int quantity = int.Parse(reader["Quantity"].ToString());
                    int unitPrice = int.Parse(reader["UnitPrice"].ToString());

                    Product product = new Product
                    {
                        ProductTitle = name,
                        ProductImage = image,
                        UnitPrice = unitPrice
                    };
                    items.Add(new Item(id, product,quantity));
                    conn.Close();
                }

             
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
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
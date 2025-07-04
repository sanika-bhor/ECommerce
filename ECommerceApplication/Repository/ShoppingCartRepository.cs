using System.Data;
using System.Data.Common;
using ECommerceApplication.Models;
using ECommerceApplication.Utils;
using MySql.Data.MySqlClient;

namespace ECommerceApplication.Repository.Interfaces
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public bool addItem(Item item, int userid)
        {
            bool Status=false;

            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = conn.CreateCommand();
            string query= "insert into cart(ItemName, ItemImage,Quantity,UnitPrice,product_id,user_id) values(@itemName,@itemImage,@quantity,@unitPrice,@productId,@userid)";
            cmd.Parameters.Add(new MySqlParameter("@itemName", item.product.ProductTitle));
            cmd.Parameters.Add(new MySqlParameter("@itemImage", item.product.ProductImage));
            cmd.Parameters.Add(new MySqlParameter("@quantity", item.Quantity));
            cmd.Parameters.Add(new MySqlParameter("@unitPrice", item.product.UnitPrice));
            cmd.Parameters.Add(new MySqlParameter("@productId", item.product.ProductId));
            cmd.Parameters.Add(new MySqlParameter("@userid", userid));

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
            bool Status = false;
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            try
            {
                conn.Open();
                cmd.CommandText = "delete from cart where itemid=@id";
                cmd.Parameters.Add(new MySqlParameter("@id", id));
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
               
                Status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return Status;
        }

        public List<Item> getAllItem(int uid)
        {
            List<Item> items = new List<Item>();
            // implement logic to get all items from database
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            IDataReader reader = null;

            string query = "select * from cart where user_id=@userid";
            
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Add(new MySqlParameter("@userid", uid));
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ItemId"].ToString());
                    string name = reader["ItemName"].ToString();
                    string image = reader["ItemImage"].ToString();
                    int quantity = int.Parse(reader["Quantity"].ToString());
                    int unitPrice = int.Parse(reader["UnitPrice"].ToString());
                    int productId = int.Parse(reader["product_id"].ToString());
                    int userid = int.Parse(reader["user_id"].ToString());
                    Product product = new Product
                    {
                        ProductId = productId,
                        ProductTitle = name,
                        ProductImage = image,
                        UnitPrice = unitPrice
                    };
                    items.Add(new Item(id, product, quantity));

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
            Item item = null;
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from cart where itemid=@id";
                cmd.Parameters.Add(new MySqlParameter("@id", id));
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id1 = int.Parse(reader["itemid"].ToString());
                    string title = reader["itemname"].ToString();
                    string img = reader["itemimage"].ToString();
                    int quantity = int.Parse(reader["Quantity"].ToString());
                    int price = int.Parse(reader["UnitPrice"].ToString());
                    int productId = int.Parse(reader["product_id"].ToString());
                    Product product = new Product
                    {
                        ProductId = productId,
                        ProductTitle = title,
                        ProductImage = img,
                        UnitPrice = price
                    };
                    item = new Item(id1, product, quantity);
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
            return item;
        }

        public Product getItemByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public bool updateItem(Item item)
        {
            bool status = false;
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE cart SET Quantity=@quantity where product_id=@id";
            cmd.Parameters.Add(new MySqlParameter("@quantity", item.Quantity));
            cmd.Parameters.Add(new MySqlParameter("@id", item.product.ProductId));
            try
            {
                conn.Open();

                cmd.ExecuteNonQuery();
                status = true;

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
            return status;
        }
    }
}

using ECommerceApplication.Repository.Interfaces;
using ECommerceApplication.Models;
using ECommerceApplication.Utils;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;

namespace ECommerceApplication.Repository
{

    public class ProductRepository : IProductRepository
    {
        // Initialize products list
        public List<Product> products = new List<Product>();
        //create connection 
        IDbConnection connection;
        public ProductRepository()
        {
            // create database connection;
             connection = DatabaseConnection.getConnection();
        }
//getAll Products Data
        public List<Product> getAllProduct()
        {
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from product";
            cmd.Connection = connection;
            IDataReader reader = null;
            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ProductId"].ToString());
                    string title = reader["Title"].ToString();
                    string description = reader["Description"].ToString();
                    int quantity = int.Parse(reader["Quantity"].ToString());
                    double unitPrice = double.Parse(reader["UnitPrice"].ToString());

                    Product product = new Product
                    {
                        ProductId = id,
                        ProductTitle = title,
                        Description = description,
                        Quantity = quantity,
                        UnitPrice = unitPrice
                    };

                    products.Add(product);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return products;
        }
   public Product getProductById(int pid)
        {
            Product product = null;
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            string query = "select * from product where ProductId=@id";
            cmd.Parameters.Add(new MySqlParameter("@id", pid));
            cmd.CommandText = query;
            cmd.Connection = conn;
            IDataReader reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                int id = int.Parse(reader["ProductId"].ToString());
                string title = reader["Title"].ToString();
                string description = reader["Description"].ToString();
                int unitPrice = int.Parse(reader["UnitPrice"].ToString());
                int quntity = int.Parse(reader["Quantity"].ToString());
                string image = reader["Image"].ToString();


                product = new Product
                {
                    ProductId = id,
                    ProductTitle = title,
                    Description = description,
                    UnitPrice = unitPrice,
                    Quantity = quntity,
                    ProductImage = image
                };
                conn.Close();

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
            return product;
        }


        public Product getProductByTitle(string ptitle)
        {
            Product product = null;
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            string query = "select * from product where ProductId=@title";
            cmd.Parameters.Add(new MySqlParameter("@title", ptitle));
            cmd.CommandText = query;
            cmd.Connection = conn;
            IDataReader reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                int id = int.Parse(reader["ProductId"].ToString());
                string title = reader["Title"].ToString();
                string description = reader["Description"].ToString();
                int unitPrice = int.Parse(reader["UnitPrice"].ToString());
                int quntity = int.Parse(reader["Quantity"].ToString());
                string image = reader["Image"].ToString();


                product = new Product
                {
                    ProductId = id,
                    ProductTitle = title,
                    Description = description,
                    UnitPrice = unitPrice,
                    Quantity = quntity,
                    ProductImage = image
                };
                conn.Close();

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
            return product;
        }





        public bool addProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool deleteProduct(int id)
        {
            throw new NotImplementedException();
        }



        public bool updateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
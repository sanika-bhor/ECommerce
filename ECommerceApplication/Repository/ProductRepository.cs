
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
                    int quantity = int.Parse(reader["Quntity"].ToString());
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







        public bool addProduct()
        {
            throw new NotImplementedException();
        }

        public bool deleteProduct()
        {
            throw new NotImplementedException();
        }

      

        public Product getProductById()
        {
            throw new NotImplementedException();
        }

        public Product getProductByTitle()
        {
            throw new NotImplementedException();
        }

        public bool updateProduct()
        {
            throw new NotImplementedException();
        }
    }
}
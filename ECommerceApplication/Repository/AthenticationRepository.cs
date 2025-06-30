using System.Data;
using ECommerceApplication.Models;
using ECommerceApplication.Repository.Interfaces;
using ECommerceApplication.Utils;
using MySql.Data.MySqlClient;

namespace ECommerceApplication.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        public bool addCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool deleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> getAllCustomers()
        {
            List<Customer> customers=new List<Customer>();
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM customers";
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerId = int.Parse(reader["CustomerId"].ToString());
                    customer.Name = reader["name"].ToString();
                    customer.PhoneNo = reader["PhoneNo"].ToString();
                    customer.Email = reader["email"].ToString();
                    customer.Password = reader["password"].ToString();
                    customer.City = reader["City"].ToString();
                    customer.DOB = Convert.ToDateTime(reader["DOB"]);
                    customers.Add(customer);
                }
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
            return customers;
        }

        public Customer getCustomerByEmail(int id)
        {
            throw new NotImplementedException();
        }

        public Customer getCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer getCustomerByName(string title)
        {
            throw new NotImplementedException();
        }

        public bool updateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
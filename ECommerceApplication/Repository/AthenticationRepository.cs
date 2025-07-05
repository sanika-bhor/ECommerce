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
            bool status = false;
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "INSERT INTO Users VALUES (@id, @name,@phno,@email,@password,@city,@dob)";
                cmd.Parameters.Add(new MySqlParameter("@id", customer.CustomerId));
                cmd.Parameters.Add(new MySqlParameter("@name", customer.Name));
                cmd.Parameters.Add(new MySqlParameter("@phno", customer.PhoneNo));
                cmd.Parameters.Add(new MySqlParameter("@email", customer.Email));
                cmd.Parameters.Add(new MySqlParameter("@password", customer.Password));
                cmd.Parameters.Add(new MySqlParameter("@city", customer.City));
                cmd.Parameters.Add(new MySqlParameter("@dob", customer.DOB));
                cmd.ExecuteNonQuery();
                status = true;
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

            return status;
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
                cmd.CommandText = "SELECT * FROM Users";
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

        public Customer getCustomerByEmail(string email)
        {
            Customer customer=new Customer();
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Users where Email=@email";
                cmd.Parameters.Add(new MySqlParameter("@email", email));
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                   
                    customer.CustomerId = int.Parse(reader["CustomerId"].ToString());
                    customer.Name = reader["name"].ToString();
                    customer.PhoneNo = reader["PhoneNo"].ToString();
                    customer.Email = reader["email"].ToString();
                    customer.Password = reader["password"].ToString();
                    customer.City = reader["City"].ToString();
                    customer.DOB = Convert.ToDateTime(reader["DOB"]);
                    reader.Close();
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
            return customer;
        }

        public Customer getCustomerById(int id)
        {

            Customer customer = new Customer();
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            IDataReader reader;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Users where CustomerId=@id";
                cmd.Parameters.Add(new MySqlParameter("@id", id));
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer.CustomerId = int.Parse(reader["CustomerId"].ToString());
                    customer.Name = reader["name"].ToString();
                    customer.PhoneNo = reader["PhoneNo"].ToString();
                    customer.City = reader["City"].ToString();
                    customer.DOB = Convert.ToDateTime(reader["DOB"]);
                    customer.Email = reader["Email"].ToString();
                    customer.Password = reader["Password"].ToString();
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
                return customer;
            }

        public Customer getCustomerByName(string name)
        {
            Customer customer = new Customer();
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            IDataReader reader;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Users where Customername=@name";
                cmd.Parameters.Add(new MySqlParameter("@@name", name));
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer.CustomerId = int.Parse(reader["CustomerId"].ToString());
                    customer.Name = reader["name"].ToString();
                    customer.PhoneNo = reader["PhoneNo"].ToString();
                    customer.City = reader["City"].ToString();
                    customer.DOB = Convert.ToDateTime(reader["DOB"]);
                    customer.Email = reader["Email"].ToString();
                    customer.Password = reader["Password"].ToString();
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
            return customer;
        }

        public bool updateCustomer(Customer customer)
        {
            bool status = false;
            IDbConnection conn = DatabaseConnection.getConnection();
            IDbCommand cmd = new MySqlCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update Users set Name=@name,PhoneNo=@phno, Email=@email, Password=@password, City=@city, DOB=@dob where Customerid=@id";
                cmd.Parameters.Add(new MySqlParameter("@id", customer.CustomerId));
                cmd.Parameters.Add(new MySqlParameter("@name", customer.Name));
                cmd.Parameters.Add(new MySqlParameter("@phno", customer.PhoneNo));
                cmd.Parameters.Add(new MySqlParameter("@email", customer.Email));
                cmd.Parameters.Add(new MySqlParameter("@password", customer.Password));
                cmd.Parameters.Add(new MySqlParameter("@city", customer.City));
                cmd.Parameters.Add(new MySqlParameter("@dob", customer.DOB));
                cmd.ExecuteNonQuery();
                status = true;
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
            return status;
        }
    }
}
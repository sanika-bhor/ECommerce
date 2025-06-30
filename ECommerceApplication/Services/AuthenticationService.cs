using ECommerceApplication.Models;
using ECommerceApplication.Repository.Interfaces;
using ECommerceApplication.Services.Interfaces;

namespace ECommerceApplication.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _AuthRepo;

        public AuthenticationService(IAuthenticationRepository repo)
        {
            _AuthRepo = repo;
        }
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
            List<Customer> customers = _AuthRepo.getAllCustomers();
            return customers;
        }

        public Customer getCustomerByEmail(string email)
        {
            Customer customer = _AuthRepo.getCustomerByEmail(email);
            return customer;
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
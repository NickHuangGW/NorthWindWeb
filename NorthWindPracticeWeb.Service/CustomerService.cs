using System.Collections.Generic;
using NorthWindPracticeWeb.Repository.Interfaces;
using NorthWindPracticeWeb.Repository.Models;
using NorthWindPracticeWeb.Service.DTOs;
using NorthWindPracticeWeb.Service.Interface;

namespace NorthWindPracticeWeb.Service
{
   public class CustomerService : ICustomerService
    {
        private readonly IGenericRepository<Customers> _customerRepository;

        public CustomerService(IGenericRepository<Customers> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<CustomerDto> GetCustomers()
        {
            throw new System.NotImplementedException();
        }

        public void CreateCustomer(CustomerDto dtoModel)
        {
            throw new System.NotImplementedException();
        }

        public void EditCustomer(string customerId)
        {
            throw new System.NotImplementedException();
        }

        public CustomerDto GetCustomerById()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCustomer(string customerId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CustomerDto> GetCustomersWithPages(int pageNumber, int pageSize)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
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
            foreach (var dt in _customerRepository.GetAll())
            {
                var customerDto = new CustomerDto
                {
                    Address = dt.Address,
                    City = dt.City,
                    CompanyName = dt.CompanyName,
                    ContactName = dt.ContactName,
                    ContactTitle = dt.ContactTitle,
                    Country = dt.Country,
                    CustomerID = dt.CustomerID,
                    Fax = dt.Fax,
                    Phone = dt.Phone,
                    PostalCode = dt.PostalCode,
                    Region = dt.Region
                };
                yield return customerDto;
            }
        }

        public void CreateCustomer(CustomerDto dtoModel)
        {
            var customer = new Customers
            {
                Address = dtoModel.Address,
                Region = dtoModel.Region,
                PostalCode = dtoModel.PostalCode,
                Phone = dtoModel.Phone,
                Fax = dtoModel.Fax,
                CustomerID = dtoModel.CustomerID,
                Country = dtoModel.Country,
                ContactTitle = dtoModel.ContactTitle,
                ContactName = dtoModel.ContactName,
                CompanyName = dtoModel.CompanyName,
                City = dtoModel.City
            };
            _customerRepository.Create(customer);
        }

        public void EditCustomer(CustomerDto dtoModel)
        {
            var customer = _customerRepository
                .Query(x => x.CustomerID == dtoModel.CustomerID).FirstOrDefault();
            customer.CompanyName = dtoModel.CompanyName;
            customer.ContactName = dtoModel.ContactName;
            customer.ContactTitle = dtoModel.ContactTitle;
            customer.Address = dtoModel.Address;
            customer.Region = dtoModel.Region;
            customer.PostalCode = dtoModel.PostalCode;
            customer.Phone = dtoModel.Phone;
            customer.Fax = dtoModel.Fax;
            customer.City = dtoModel.City;
        }

        public CustomerDto GetCustomerById(string customerId)
        {
            var customer = _customerRepository
                .Query(x => x.CustomerID == customerId).FirstOrDefault();
            return new CustomerDto
            {
                Address = customer.Address,
                Region = customer.Region,
                PostalCode = customer.PostalCode,
                Phone = customer.Phone,
                Fax = customer.Fax,
                CustomerID = customer.CustomerID,
                Country = customer.Country,
                ContactTitle = customer.ContactTitle,
                ContactName = customer.ContactName,
                CompanyName = customer.CompanyName,
                City = customer.City
            };
        }

        public void DeleteCustomer(string customerId)
        {
            var customer = _customerRepository
                .Query(x => x.CustomerID == customerId).FirstOrDefault();
            _customerRepository.Delete(customer);
        }
    }
}
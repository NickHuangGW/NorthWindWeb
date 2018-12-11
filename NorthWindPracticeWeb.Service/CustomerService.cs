using System.Collections.Generic;
using System.Linq;
using AutoMapper;
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
            var models = _customerRepository.GetAll();
            var dtoModels =
                Mapper.Map<IEnumerable<Customers>, IEnumerable<CustomerDto>>(models);
            return dtoModels;
        }

        public void CreateCustomer(CustomerDto dtoModel)
        {
            var customer =
                Mapper.Map<CustomerDto, Customers>(dtoModel);
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
           return Mapper.Map<Customers, CustomerDto>(customer);
        }

        public void DeleteCustomer(string customerId)
        {
            var customer = _customerRepository
                .Query(x => x.CustomerID == customerId).FirstOrDefault();
            _customerRepository.Delete(customer);
        }
    }
}
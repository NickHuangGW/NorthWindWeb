using System.Collections.Generic;
using NorthWindPracticeWeb.Service.DTOs;

namespace NorthWindPracticeWeb.Service.Interface
{
    public interface ICustomerService
    {
        IEnumerable<CustomerDto> GetCustomers();

        void CreateCustomer(CustomerDto dtoModel);

        void EditCustomer(string customerId);

        CustomerDto GetCustomerById();

        void DeleteCustomer(string customerId);

        IEnumerable<CustomerDto> GetCustomersWithPages(int pageNumber, int pageSize);
    }
}
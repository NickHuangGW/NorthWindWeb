using System.Collections.Generic;
using NorthWindPracticeWeb.Service.DTOs;

namespace NorthWindPracticeWeb.Service.Interface
{
    public interface ICustomerService
    {
        IEnumerable<CustomerDto> GetCustomers();

        void CreateCustomer(CustomerDto dtoModel);

        void EditCustomer(CustomerDto dtoModel);

        CustomerDto GetCustomerById(string customerId);

        void DeleteCustomer(string customerId);

    }
}
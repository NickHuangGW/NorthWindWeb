using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using NorthWindPracticeWeb.Models;
using NorthWindPracticeWeb.Service.DTOs;
using NorthWindPracticeWeb.Service.Interface;

namespace NorthWindPracticeWeb.Areas.Customer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: Customer/Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(int pageNumber = 1, int pageSize = 20)
        {
            var dtoModels = _customerService.GetCustomers();
            var viewModels =
                Mapper.Map<IEnumerable<CustomerDto>, IEnumerable<CustomerViewModel>>(dtoModels);
            return View("_List", viewModels);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(string customerId)
        {
            return View(_customerService.GetCustomerById(customerId));
        }
        public ActionResult Delete(string customerId)
        {
            return View(_customerService.GetCustomerById(customerId));
        }
    }
}
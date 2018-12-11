using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return View("_List");
        }

    }
}
using AutoMapper;
using NorthWindPracticeWeb.Models;
using NorthWindPracticeWeb.Repository.Interfaces;
using NorthWindPracticeWeb.Service.DTOs;
using NorthWindPracticeWeb.Service.Interface;
using System.Collections.Generic;
using System.Web.Mvc;
using NorthWindPracticeWeb.Controllers;

namespace NorthWindPracticeWeb.Areas.Customer.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService, IUnitOfWork unitOfWork)
        {
            _customerService = customerService;
            _unitOfWork = unitOfWork;
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerViewModel viewModel)
        {
            if (ModelState.IsValid == false)
            {
                return View(viewModel);
            }
            var dto = Mapper.Map<CustomerViewModel, CustomerDto>(viewModel);
            _customerService.CreateCustomer(dto);
            _unitOfWork.CommitTrans();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string customerId)
        {
            var customer = _customerService.GetCustomerById(customerId);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewModel = Mapper.Map<CustomerDto, CustomerViewModel>(customer);
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerViewModel viewModel)
        {
            if (ModelState.IsValid == false)
            {
                return View(viewModel);
            }
            var dto = Mapper.Map<CustomerViewModel, CustomerDto>(viewModel);
            _customerService.CreateCustomer(dto);
            _unitOfWork.CommitTrans();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string customerId)
        {
            var customer = _customerService.GetCustomerById(customerId);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewModel = Mapper.Map<CustomerDto, CustomerViewModel>(customer);
            return View(viewModel);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCustomer(string customerId)
        {
            _customerService.DeleteCustomer(customerId);
            _unitOfWork.CommitTrans();
            return RedirectToAction("Index");

        }
    }
}
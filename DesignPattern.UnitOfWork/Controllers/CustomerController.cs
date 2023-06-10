﻿using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var sender = _customerService.TGetById(model.SenderId);
            var receiver = _customerService.TGetById(model.Receiver);

            sender.CustomerBalance -= model.Amount;
            receiver.CustomerBalance += model.Amount;

            List<Customer> modifiedCustomers = new List<Customer>()
            {
                sender,
                receiver
            };

            _customerService.TMultiUpdate(modifiedCustomers);
            return View();
        }
    }
}

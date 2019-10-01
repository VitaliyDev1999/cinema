using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController:Controller
    {
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer{Id=1, Name="mary jane"},
                new Customer{Id=2, Name="alex crab"},
                new Customer{Id=3, Name="martin scorceze"}
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Profile(int id)
        {
            var customers = new List<Customer>
            {
                new Customer{Id=1, Name="mary jane"},
                new Customer{Id=2, Name="alex crab"},
                new Customer{Id=3, Name="martin scorceze"}
            };

            foreach(var customer in customers)
            {
                if (customer.Id == id)
                {
                    var data = customer;
                    return View(customer);
                }
            }

            return HttpNotFound();
        }
    }
}
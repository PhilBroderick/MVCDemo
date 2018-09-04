using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Phil Broderick" },
                new Customer { Id = 2, Name = "Calvin Phillips" }
            };

            var viewModel = new CustomerListViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int? id)
        {
            return null;
        }
    }
}
﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        { _context = new ApplicationDbContext(); }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            //var customers = GetCustomers();
            var customers = _context.Customers.Include(c => c.MembershipType);
            return View(customers);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return Content("Please provide cutomer ID");
            }
            else
            {
                var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
                //var customer = GetCustomers().Customers.SingleOrDefault(c => c.Id == id);
                if (customer == null)
                    return HttpNotFound();

                return View(customer);
            }

        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer { Id = 1, Name = "John Smith" },
        //        new Customer { Id = 2, Name = "Mary Williams" }
        //    };
        //}
    }
}
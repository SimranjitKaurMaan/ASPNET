using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentalStore.Models;
using RentalStore.ViewModels;

namespace RentalStore.Controllers
{
    public class CustomersController : Controller
    {
        

        // GET: Customers/Index
        public ActionResult Index()
        {

            //return Content("Hellp Customers");
            var customers = GetCustomers();
           return View(customers);
        }

        //GET : Customers/Details/Id
        public ActionResult Details(int? Id)
        {
            var customers = GetCustomers();
            foreach(var customer in customers)
            {
                if(customer.Id==Id)
                {
                    return View(customer);
                }
            }
            return Content("Customer not found");
             
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var Customers = new List<Customer>
            {
               new Customer{Name =  "John Smith",Id = 1000},
                new Customer{Name =  "Mary Williams",Id=1001}

            };

            return Customers;
        }
       
        
    }
}
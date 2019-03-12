
using System;
using System.Collections.Generic;

using System.Web.Mvc;
using VidlyApp.DbContext;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {

            var customers = new List<Customer>
            {
                new Customer {Name = "Andranik Atoyan", Id=1},
                new Customer {Name = "Agnija Bako", Id=2}

            };

            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
           
            int constructorId = id;
            var customers = new List<Customer>
            {
                new Customer {Name = "Andranik Atoyan", Id=1},
                new Customer {Name = "Agnija Bako", Id=2}

            };
             var dbCustomerSave = new MyDbContext();
            
             foreach (var customer in customers)
             {
                 try
                 {
                     dbCustomerSave.Customers.Add(customer);
                     dbCustomerSave.SaveChanges();
                }
                 catch (Exception E)
                 {
                   
                     
                 }
                
            }

             
            var specificCustomer = customers.Find(x => x.Id==constructorId);
            var viewModel = new RandomMovieViewModel()
            {
                Customer = specificCustomer

            };

                        return View(viewModel);
        }
    }

}
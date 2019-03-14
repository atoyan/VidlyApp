
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VidlyApp.DbContext;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class CustomersController : Controller
    {
        private MyDbContext _context;

        public CustomersController()
        {
            _context = new MyDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {
            List< Customer>  customersList= new List<Customer>();
            customersList.Add(new Customer()
            {
                Id=_context.Customers.Find(1).Id,
                Name = _context.Customers.Find(1).Name

            });
            customersList.Add(new Customer()
            {
                Id = _context.Customers.Find(2).Id,
                Name = _context.Customers.Find(2).Name

            });



            var viewModel = new RandomMovieViewModel()
            {
            Customers = customersList
                
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
           
            int constructorId = id;
           
            

             
            var specificCustomer = _context.Customers.Find(constructorId);
            var viewModel = new RandomMovieViewModel()
            {
                Customer = specificCustomer

            };

                        return View(viewModel);
        }
    }

}
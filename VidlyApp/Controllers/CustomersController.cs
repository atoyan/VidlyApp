
using System.Collections.Generic;

using System.Web.Mvc;
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
                new Customer {name = "Andranik Atoyan", id=1},
                new Customer {name = "Agnija Bako", id=2}

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
                new Customer {name = "Andranik Atoyan", id=1},
                new Customer {name = "Agnija Bako", id=2}

            };
            var specificCustomer = customers.Find(x => x.id==constructorId);
            var viewModel = new RandomMovieViewModel()
            {
                Customer = specificCustomer

            };

                        return View(viewModel);
        }
    }

}
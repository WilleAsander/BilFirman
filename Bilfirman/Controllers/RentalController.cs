using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bilfirman.Models;

namespace Bilfirman.Controllers
{
    public class RentalController : Controller
    {
        private List<Car> cars;
        private List<Customer> customers;

        public RentalController()
        {
            cars = new List<Car>();
            cars.Add(new Car() { Registration = "AVD125", Model = "i3", Manufacturer = "BMW", Color = "Green", Rented=true});
            cars.Add(new Car() { Registration = "BFC591", Model = "Leaf", Manufacturer = "Nissan", Color = "Pink", Rented = false });
            cars.Add(new Car() { Registration = "HDE146", Model = "3", Manufacturer = "Tesla", Color = "Red", Rented = false});

            customers = new List<Customer>();
            customers.Add(new Customer() { Name = "Christer" });
        }

        // GET: Rental
        public ActionResult Index()
        {
            return View(cars);
        }

        public ActionResult Cars()
        {
            return PartialView("_Cars", cars);
        }

        public ViewResult  Details (string Registration)
        {
            return View("CarDetails", cars.First(x => x.Registration == Registration));
        }

        public PartialViewResult Customers()
        {
            return PartialView("_Customers", customers);
        }

        
    }
}
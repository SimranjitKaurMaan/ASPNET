using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentalStore.Models;
using RentalStore.ViewModels;

namespace RentalStore.Controllers
{
    //cars/random - create a page with cars and we can randomly pick a car from it
    public class CarsController : Controller
    {
        // GET: Cars /Cars/Random
        public ActionResult Random()
        {
            
            //var cars = new List<Car>
            //{
            //    new Car {Name = "Mahindra KUV",Id=1},
            //    new Car {Name= "Maruti Swift",Id=2}

            // };

            //var viewmodel = new RandomViewModel
            //{
            //    Cars = GetCars()
                
            //};

            return View(GetCars());
            // return Content("Hello Rent a car");
            //return HttpNotFound("Not found page!  Something is broken! Hold back ");
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });



        }

        //GET: /Cars/Edit/1
        public ActionResult Edit(int Id)
        {
            return Content("id=" + Id);

        }


        [Route("cars/available/{month}/{date}")]
        public ActionResult Availability(int month,int date)
        {
            return Content(month + "," + date);

        }

        //GET : Cars/Details/Id
        public ActionResult Details(int? id)
        {
            var cars = GetCars();
            foreach(var car in cars)
            {
                if(id==car.Id)
                    return View(car);
            }
            return Content("Car not found");

        }

        private IEnumerable<Car> GetCars()
        {
            var cars = new List<Car>
            {
                new Car {Name = "Mahindra KUV",Id=1},
                new Car {Name= "Maruti Swift",Id=2}

             };

            return cars;
        }


    }
}
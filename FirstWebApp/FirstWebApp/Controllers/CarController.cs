using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;
using FirstWebApp.Services;
using FirstWebApp.Repository;

namespace FirstWebApp.Controllers
{
    public class CarController : Controller
    {
        private CarsService _carService;
        public CarController()
        {
            _carService = new CarsService();
        }

        // GET: CarController
        public ActionResult Index()
        {


            var cars = _carService.GetAll();
            return View(cars);
        }

        //GET: CarController/Details/5
        public ActionResult Details(int id)
        {
            var model = _carService.GetCarById(id);
            return View(model);
        }
        // GET: CarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _carService.GetCarById(id);
            return View(model);
        }
        //GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _carService.GetCarById(id);
            return View(model);
        }

        // POST: CarController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car carToAdd)
        {
            _carService.AddCar(carToAdd);
            return RedirectToAction(nameof(Index));
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Car cartoEdit)
        {
            try
            {
                _carService.EditCar(cartoEdit);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Car car)
        {
            _carService.RemoveCar(car);
            return RedirectToAction(nameof(Index));
        }
    }
}

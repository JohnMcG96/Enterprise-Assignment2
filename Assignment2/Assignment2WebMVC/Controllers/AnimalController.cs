using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2Data.Animal;
using Assignment2Data.Services;
using Microsoft.AspNetCore.Authorization;

namespace Assignment2WebMVC.Controllers
{
    [Authorize]
    public class AnimalController : Controller
    {
        private IAnimalDataService service;
        public AnimalController()

        {
            service = new AnimalDataService();

        }
        [HttpGet]
        public IActionResult Index()

        {
            List<Animals> animal = (List<Animals>)service.SelectAll();
            return View(animal);

        }
        [HttpGet]
        public IActionResult Create()

        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Animals obj)

        {
            if (ModelState.IsValid)
            { // check valid state
                service.Insert(obj);
                return RedirectToAction("Index");

            }
            else // not valid so redisplay

            {
                return View(obj);

            }

        }
        [HttpGet, ActionName("Delete")]
        public IActionResult Delete(int id)

        {
            Animals existing = service.SelectByID(id);
            return View(existing);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Animals existing = service.SelectByID(id);
            return View(existing);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult ConfirmEdit(Animals obj)
        {
            if (ModelState.IsValid)
            { // check valid state
                service.Update(obj);
                return RedirectToAction("Index");
            }
            else // not valid so redisplay
            {
                return View(obj);
            }
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Animals existing = service.SelectByID(id);
            return View(existing);
        }

    }
}
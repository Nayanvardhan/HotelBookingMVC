using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {

        public static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        { 
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dvm= new DogViewModel();
            return View();
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Hello()
        {
            return View();
        }
    }
} 

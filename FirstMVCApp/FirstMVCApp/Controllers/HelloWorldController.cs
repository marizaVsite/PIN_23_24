using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //lista koja simulira bazu i u nju dodajemo nove pse
        private static List<Dog> dogs = new List<Dog>();
        public IActionResult Index()
        {
            //vraća Index view koji nam služi za prikaz svih pasa u listi
            return View(dogs);
        }

        public IActionResult Create()
        {
            //pozivamo Create View i proslijeđujemo prazan objekt
            Dog dog = new Dog();
            return View(dog);
        }

        public IActionResult CreateDog(Dog dogViewModel)
        {
            //dodajemo psa u listu
            dogs.Add(dogViewModel);
            //preusmjeravamo na akciju Index kako bi prikazali sve pse
            return RedirectToAction("Index");
        }



        public string Hello()
        {
            return "Hello";
        }
    }


}



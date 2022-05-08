using AhmadEmami_hw008_maktab71.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AhmadEmami_hw008_maktab71.Controllers
{
    public class HomeController : Controller
    {
        private PersonRepository _personRepository;
       // private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
            _personRepository = new PersonRepository();
        }

        public IActionResult Index()
        {
            var persons = Models.PersonRepository.GetAllPersons();
            return View("Index",persons);

        }
        public IActionResult Delete(int id)
        {
            var person = _personRepository.GetPersonDetails(id);
            return View(person);
        }

        public IActionResult DeletePerson(PersonModel model)
        {
            _personRepository.DeletePerson(model.Id);
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Homework10.Models;
using Homework10.Infrastructures;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework10.Controllers
{
    public class LibrariesController : Controller
    {
        private readonly IRepository _repository = new Repository();
        public IActionResult Index()
        {
            var library = _repository.GetAllLibraries();
            return View("Index", library);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Library library)
        {

            
            _repository.AddLibrary(library);
            return RedirectToAction("Index");
        }
       
    }
}

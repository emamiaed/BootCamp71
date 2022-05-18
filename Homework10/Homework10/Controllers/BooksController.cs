using Homework10.Models;
using Homework10.Infrastructures;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework10.Controllers
{
    public class BooksController : Controller
    {
        private readonly IRepository _repository = new Repository();
        public IActionResult Index()
        {
            var book = _repository.GetAllBooks();
            return View("Index", book);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Book book)
        {

            
            _repository.AddBook(book);
            return RedirectToAction("Index");
        }
       
    }
}

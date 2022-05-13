using Exam2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Exam2.DAL;
using PersianDate;
using Exam2.Entities;

namespace Exam2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository = new Repository();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {


            //var categories = _repository.GetAllCategories();
            //categories.Insert(0,new Category{Id=0,Name="یک گروه انتخاب کنید"});


            var products = _repository.GetAllProducts();
            return View("Index",products);
        }

        //public IActionResult DropdownController()
        //{
        //    var categories = _repository.GetAllCategories();
        //    return View("Index", categories);
        //}


        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Product product)
        {
            product.UserId = 1;
            product.CreateDate = ToShamsi(product.CreateDate);
            _repository.AddProduct(product);
            return RedirectToAction("Index");
        }

        private DateTime ToShamsi(DateTime createDate)
        {
            throw new NotImplementedException();
        }


        public IActionResult Details(int id)
        {
            var product = _repository.GetProductDetail(id);
            return View(product);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var produc = _repository.GetProductDetail(id);
            return View(produc);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _repository.UpdateProduct(product);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var produc = _repository.GetProductDetail(id);
            return View(produc);
        }

        public IActionResult DeleteProduct(Product product)
        {
            _repository.DeleteProduct(product.Id);
            return RedirectToAction("Index");
        }



        public IActionResult Privacy()
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
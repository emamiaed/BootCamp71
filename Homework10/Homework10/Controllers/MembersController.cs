using Homework10.Models;
using Homework10.Infrastructures;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework10.Controllers
{
    public class MembersController : Controller
    {
        private readonly IRepository _repository = new Repository();
        public IActionResult Index()
        {
            var members = _repository.GetAllMembers();
            return View("Index", members);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Member member)
        {

            
            _repository.AddMember(member);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var member = _repository.GetMemberDetail(id);
            return View(member);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var member = _repository.GetMemberDetail(id);
            return View(member);
        }
        [HttpPost]
        public IActionResult Edit(Member member)
        {
            _repository.UpdateMember(member);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var member = _repository.GetMemberDetail(id);
            return View(member);
        }

        public IActionResult DeleteMember(Member member)
        {
            _repository.DeleteMember(member.Id);
            return RedirectToAction("Index");
        }
    }
}

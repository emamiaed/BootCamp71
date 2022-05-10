using AhmadEmami_hw009_maktab71.Models;
using Microsoft.AspNetCore.Mvc;

namespace AhmadEmami_hw009_maktab71.Controllers;

public class MembersController : Controller
{
    private MemberRepository _memberRepository;
    public MembersController()
    {
        _memberRepository = new MemberRepository();
    }
    [HttpGet]
    // GET
    public IActionResult Index()
    {
        var member = _memberRepository.GetAllMembers();

        return View("Index",member);
    }
    [HttpGet]
    public IActionResult create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult create(Member model)
    {
        _memberRepository.AddMember(model);
        return RedirectToAction("Index");
    }
    public IActionResult Details(int id)
    {
        var members = _memberRepository.GetMemberDetails(id);
        return View(members);
    }
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var member = _memberRepository.GetMemberDetails(id);
        return View(member);
    }
    [HttpPost]
    public IActionResult Edit(Member model)
    {
        _memberRepository.UpdateMember(model);
        return RedirectToAction("Index");
    }
    public IActionResult Delete(int id)
    {
        var member = _memberRepository.GetMemberDetails(id);
        return View(member);
    }

    public IActionResult DeleteMember(Member model)
    {
        _memberRepository.DeleteMember(model.Id);
        return RedirectToAction("Index");
    }
}
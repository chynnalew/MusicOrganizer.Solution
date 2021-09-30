using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;

namespace ProjectName.Controllers
{
  public class ProjectNameController : Controller
  {
    [HttpGet("/project")]
    public ActionResult Index()
    {
      return View();
    }
    
    [HttpGet("/project/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/project")]
    public ActionResult Create()
    {
      // Packer myItems = new Packer(items);
      return RedirectToAction("Index");
    }
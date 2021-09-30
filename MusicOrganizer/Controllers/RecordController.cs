using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class RecordController : Controller
  {
    [HttpGet("/record")]
    public ActionResult Index()
    {
      List<Record> allRecords = Record.GetList();
      return View(allRecords);
    }
    
    [HttpGet("/record/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/record")]
    public ActionResult Create(string recordName, string artistName)
    {
      Record myRecords = new Record(recordName, artistName);
      return RedirectToAction("Index");
    }

    [HttpGet("/record/{Id}")]
    public ActionResult Show(int Id)
    {
      Record selectedRecord = Record.FindRecord(Id);
      return View(selectedRecord);
    }

    [HttpPost("/record/{Id}")]
    public ActionResult Destroy(int Id)
    {
      Record.DeleteRecord(Id);
      return View();
    }

    [HttpPost("/record/delete")]
    public ActionResult DeleteAll()
    {
      Record.ClearAll();
      return View();
    }
  }
}
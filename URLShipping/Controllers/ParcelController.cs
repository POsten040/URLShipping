using Microsoft.AspNetCore.Mvc;
using URLShipping.Models;
using System.Collections.Generic;

namespace URLShipping.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }
    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/parcels")]
    public ActionResult Create(string name, int weight, int length, int height, int width)
    {
      Parcel myParcel = new Parcel(name, weight, length, height, width);
      
      return RedirectToAction("Index");
    }
  }
}
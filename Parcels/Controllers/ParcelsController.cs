using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }
    // [HttpGet("/parcels/cost")]
    // public ActionResult Cost()
    // {
    //   return View();
    // }

    [HttpGet("/parcels/new")]
    public ActionResult CreateParcel()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int height, int width, int length, int weight, string name, string to, string from)
    {
      Parcel newParcel = new Parcel(height, width, length, weight, name, to, from);
      return RedirectToAction("Index");
    }

    // [HttpPost("/parcels")]
    // public ActionResult Cost(int height, int width, int length, int weight, string name, string to, string from)
    // {
    //   Parcel myParcel = new Parcel(height, width, length, weight, name, to, from);
    //   //return RedirectToAction("Index");
    //   return View(myParcel);
    // }
  }
}
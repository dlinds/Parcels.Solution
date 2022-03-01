using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}


// public ActionResult CostCalc(int height, int width, int length, int weight, string name, string to, string from)
//  Parcel myParcel = new Parcel(height, width, length, weight, name, to, from);
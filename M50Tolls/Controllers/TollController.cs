using M50Tolls.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace M50Tolls.Controllers
{
    public class TollController : Controller
    { 
        // GET: TollController/Create
        public ActionResult Calculate()
        {
            ViewBag.VehicleType = new SelectList(Vehicle.VehicleTypes);
            return View(new Vehicle {VehicleType = "Car", HasETag = false});
        }

        // POST: TollController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculate(Vehicle vehicle)
        {
            ViewBag.VehicleType = new SelectList(Vehicle.VehicleTypes);
            return View(vehicle);
        }
    }
}
